using System.Collections.Generic;
using Newtonsoft.Json;

namespace Trakr.Libs.TvMaze.Models
{
    public class Schedule
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("days")]
        public List<string> Days { get; set; }
    }
}