using Newtonsoft.Json;

namespace Trakr.Libs.TvMaze.Models
{
    public class Links
    {
        [JsonProperty("self")]
        public Nextepisode Self { get; set; }

        [JsonProperty("previousepisode")]
        public Nextepisode Previousepisode { get; set; }

        [JsonProperty("nextepisode")]
        public Nextepisode Nextepisode { get; set; }
    }
}