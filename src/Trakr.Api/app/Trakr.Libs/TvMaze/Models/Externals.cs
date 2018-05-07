using Newtonsoft.Json;

namespace Trakr.Libs.TvMaze.Models
{
    public class Externals
    {
        [JsonProperty("tvrage")]
        public long? Tvrage { get; set; }

        [JsonProperty("thetvdb")]
        public long? Thetvdb { get; set; }

        [JsonProperty("imdb")]
        public string Imdb { get; set; }
    }
}