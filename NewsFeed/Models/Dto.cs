using Newtonsoft.Json;

namespace NewsFeed.Models
{
    public class Dto
    {
        public string title { get; set; }
        public string uri { get; set; }
        public string postedBy { get; set; }
        public int time { get; set; }
        public int score { get; set; }
        public int commentCount { get; set; }
    }
}
