using Newtonsoft.Json;

namespace Trakr.Libs.TvMaze.Models
{
    public class Episode
    {
        public override string ToString()
        {
            return $"S{Season:00}E{Number:00} {Name}";
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("season")]
        public long Season { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("airdate")]
        public System.DateTime Airdate { get; set; }

        [JsonProperty("airtime")]
        public string Airtime { get; set; }

        [JsonProperty("airstamp")]
        public System.DateTime Airstamp { get; set; }

        [JsonProperty("runtime")]
        public long Runtime { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("_links")]
        public EpisodeLinks Links { get; set; }
    }
}