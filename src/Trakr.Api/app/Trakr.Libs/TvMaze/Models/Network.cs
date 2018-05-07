using Newtonsoft.Json;

namespace Trakr.Libs.TvMaze.Models
{
    public class Network
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }
    }
}