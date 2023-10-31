using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace News.Model
{
    public class NewsToday
    {
        //public int Id { get; set; }
        [JsonPropertyName("title")]
        public String Title { get; set; }
        [JsonPropertyName("description")]
        public String Content { get; set; }
        [JsonPropertyName("image_url")]
        public String ImageUrl { get; set; }
    }
}
