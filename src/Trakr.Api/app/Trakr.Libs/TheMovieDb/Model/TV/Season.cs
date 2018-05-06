using System;
using Newtonsoft.Json;

namespace Trakr.Libs.TheMovieDb.Model.TV
{
    
    public class Season
    {
        [JsonProperty("id" )]
        public int Id { get; set; }

        [JsonProperty("air_date" )]
        public DateTime AirDate { get; set; }

        [JsonProperty("episode_count" )]
        public int EpisodeCount { get; set; }

        [JsonProperty("poster_path" )]
        public string PosterPath { get; set; }

        [JsonProperty("season_number" )]
        public int SeasonNumber { get; set; }

        public Season( int id, DateTime airDate, int episodeCount, string posterPath, int seasonNumber )
        {
            Id = id;
            AirDate = airDate;
            EpisodeCount = episodeCount;
            PosterPath = posterPath;
            SeasonNumber = seasonNumber;
        }

        public override string ToString()
            => $"({SeasonNumber} - {AirDate:yyyy-MM-dd})";
    }
}
