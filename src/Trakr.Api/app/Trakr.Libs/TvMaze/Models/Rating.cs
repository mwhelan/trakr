using Newtonsoft.Json;

namespace Trakr.Libs.TvMaze.Models
{
    public class Rating
    {
        [JsonProperty("average")]
        public double? Average { get; set; }
    }
}