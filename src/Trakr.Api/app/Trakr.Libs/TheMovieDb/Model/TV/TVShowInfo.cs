using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Trakr.Libs.TheMovieDb.Model.Genres;

// ReSharper disable UnusedAutoPropertyAccessor.Local

namespace Trakr.Libs.TheMovieDb.Model.TV
{
    
    public class TVShowInfo
    {
        [JsonProperty("id" )]
        public int Id { get; private set; }

        [JsonProperty("name" )]
        public string Name { get; private set; }

        [JsonProperty("original_name" )]
        public string OriginalName { get; private set; }

        [JsonProperty("poster_path" )]
        public string PosterPath { get; set; }

        [JsonProperty("backdrop_path" )]
        public string BackdropPath { get; set; }

        [JsonProperty("popularity" )]
        public double Popularity { get; private set; }

        [JsonProperty("vote_average" )]
        public double VoteAverage { get; private set; }

        [JsonProperty("vote_count" )]
        public int VoteCount { get; private set; }

        [JsonProperty("overview" )]
        public string Overview { get; private set; }

        [JsonProperty("first_air_date" )]
        public DateTime FirstAirDate { get; private set; }

        [JsonProperty("origin_country" )]
        public IReadOnlyList<string> OriginCountry { get; private set; }

        [JsonProperty("genre_ids" )]
        internal IReadOnlyList<int> GenreIds { get; set; }

        public IReadOnlyList<Genre> Genres { get; internal set; }

        [JsonProperty("original_language" )]
        public string OriginalLanguage { get; private set; }

        public TVShowInfo()
        {
            OriginCountry = new string[0];
            GenreIds = new int[0];
            Genres = new Genre[0];
        }

        public override string ToString()
            => $"{Name} ({Id} - {FirstAirDate:yyyy-MM-dd})";
    }
}
