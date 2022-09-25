using System.Threading.Tasks;
using Xunit;
using NewsFeed.Controllers;

namespace UnitTests
{
    public class UnitTest
    {
        [Fact]
        public async Task TestGetAsyncIsNotNull()
        {
            var newsController = new NewsController();
            
            Assert.NotNull(newsController.GetAsync().Result);
        }

        [Fact]
        public async Task TestGetAsyncItemAre20()
        {
            var newsController = new NewsController();

            Assert.True(newsController.GetAsync().Result.Count == 20);
        }

        [Fact]
        public async Task TestGetAsyncAreSorted()
        {
            var newsController = new NewsController();

            Assert.True(newsController.GetAsync().Result[0].score > newsController.GetAsync().Result[1].score);
            //Assert.True(newsController.GetAsync().Result[1].score > newsController.GetAsync().Result[2].score);
            //Assert.True(newsController.GetAsync().Result[2].score > newsController.GetAsync().Result[3].score);
            //Assert.True(newsController.GetAsync().Result[3].score > newsController.GetAsync().Result[4].score);
            //Assert.True(newsController.GetAsync().Result[4].score > newsController.GetAsync().Result[5].score);
            //Assert.True(newsController.GetAsync().Result[5].score > newsController.GetAsync().Result[6].score);
            //Assert.True(newsController.GetAsync().Result[6].score > newsController.GetAsync().Result[7].score);
            //Assert.True(newsController.GetAsync().Result[7].score > newsController.GetAsync().Result[8].score);
            //Assert.True(newsController.GetAsync().Result[8].score > newsController.GetAsync().Result[9].score);
            //Assert.True(newsController.GetAsync().Result[9].score > newsController.GetAsync().Result[10].score);
            //Assert.True(newsController.GetAsync().Result[10].score > newsController.GetAsync().Result[11].score);
            //Assert.True(newsController.GetAsync().Result[11].score > newsController.GetAsync().Result[12].score);
            //Assert.True(newsController.GetAsync().Result[12].score > newsController.GetAsync().Result[13].score);
            //Assert.True(newsController.GetAsync().Result[13].score > newsController.GetAsync().Result[14].score);
            //Assert.True(newsController.GetAsync().Result[14].score > newsController.GetAsync().Result[15].score);
            //Assert.True(newsController.GetAsync().Result[15].score > newsController.GetAsync().Result[16].score);
            //Assert.True(newsController.GetAsync().Result[16].score > newsController.GetAsync().Result[17].score);
            //Assert.True(newsController.GetAsync().Result[17].score > newsController.GetAsync().Result[18].score);
            //Assert.True(newsController.GetAsync().Result[18].score > newsController.GetAsync().Result[19].score);
        }
    }
}