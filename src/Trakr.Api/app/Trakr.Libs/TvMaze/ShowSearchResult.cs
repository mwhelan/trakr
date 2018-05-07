using Newtonsoft.Json;
using Trakr.Libs.TvMaze.Models;

namespace Trakr.Libs.TvMaze
{
    public class ShowSearchResult
    {
        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("show")]
        public Show Show { get; set; }
    }
}