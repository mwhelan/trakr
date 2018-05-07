using System.Collections.Generic;
using Newtonsoft.Json;

namespace Trakr.Libs.TvMaze.Models
{
    public class Embedded
    {
        [JsonProperty("episodes")]
        public List<Episode> Episodes { get; set; } = new List<Episode>();
    }
}