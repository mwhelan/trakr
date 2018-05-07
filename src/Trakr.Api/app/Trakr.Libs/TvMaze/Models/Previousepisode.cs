using Newtonsoft.Json;

namespace Trakr.Libs.TvMaze.Models
{
    public class Previousepisode
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
