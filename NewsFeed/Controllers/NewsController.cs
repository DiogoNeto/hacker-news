using Microsoft.AspNetCore.Mvc;
using NewsFeed.Models;
using System.Text.Json;

namespace NewsFeed.Controllers
{
    [Route("/best20")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        [HttpGet("json"), FormatFilter]
        public async Task<List<Dto>> GetAsync()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://hacker-news.firebaseio.com/v0/beststories.json");
            string responseBody = await response.Content.ReadAsStringAsync();

            responseBody = responseBody.Substring(1, responseBody.Length - 2);
            string[] responseArr = responseBody.Split(',');
            var news = new List<Entry>();
            foreach (string r in responseArr)
            {
                response = await client.GetAsync("https://hacker-news.firebaseio.com/v0/item/" + r + ".json");
                responseBody = await response.Content.ReadAsStringAsync();
                try
                {
                    var jsonResponse = JsonSerializer.Deserialize<Entry>(responseBody);
                    news.Add(jsonResponse);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("ERROR - " + ex.Message);
                    throw ex;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("ERROR - " + ex.Message);
                    throw ex;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR - " + ex.Message);
                    throw ex;
                }
                responseArr = responseBody.Split(',');
            }

            news.OrderBy(x => x.score);

            var newsDto = news.Select(x => new Dto { title = x.title, postedBy = x.by, uri = x.url, time = x.time, score = x.score, commentCount = x.kids.Count() });
            
            return newsDto.Take(20).ToList();
        }
    }
}
