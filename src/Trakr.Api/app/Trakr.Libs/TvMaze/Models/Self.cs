using Newtonsoft.Json;

namespace Trakr.Libs.TvMaze.Models
{
    public class Self
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}