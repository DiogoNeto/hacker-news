using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace NewsFeed.Models
{
    public class Entry
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string by { get; set; }
        public string url { get; set; }
        public int time { get; set; }
        public int score { get; set; }
        public int[] kids { get; set; }
        public string type { get; set; }
    }
}
