using Newtonsoft.Json;

namespace Trakr.Libs.TvMaze.Models
{
    public class EpisodeLinks
    {
        [JsonProperty("self")]
        public Self Self { get; set; }
    }
}