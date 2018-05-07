using Newtonsoft.Json;

namespace Trakr.Libs.TvMaze.Models
{
    public class Nextepisode
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}