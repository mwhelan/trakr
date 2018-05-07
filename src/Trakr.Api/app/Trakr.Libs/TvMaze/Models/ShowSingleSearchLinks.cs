using Newtonsoft.Json;

namespace Trakr.Libs.TvMaze.Models
{
    public class ShowSingleSearchLinks
    {
        [JsonProperty("self")]
        public Self Self { get; set; }

        [JsonProperty("previousepisode")]
        public Self Previousepisode { get; set; }
    }
}
