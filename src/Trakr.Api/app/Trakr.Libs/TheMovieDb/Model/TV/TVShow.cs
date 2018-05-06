using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Trakr.Libs.TheMovieDb.Model.Companies;
using Trakr.Libs.TheMovieDb.Model.Genres;
using Trakr.Libs.TheMovieDb.Model.Keywords;

namespace Trakr.Libs.TheMovieDb.Model.TV
{
    
    public class TVShow
    {
        [JsonProperty("id" )]
        public int Id { get; set; }

        [JsonProperty("backdrop_path" )]
        public string BackdropPath { get; set; }

        [JsonProperty("created_by" )]
        public IReadOnlyList<TVShowCreator> CreatedBy { get; set; }

        [JsonProperty("episode_run_time" )]
        public IReadOnlyList<int> EpisodeRunTime { get; set; }

        [JsonProperty("first_air_date" )]
        public DateTime FirstAirDate { get; set; }

        [JsonProperty("genres" )]
        public IReadOnlyList<Genre> Genres { get; set; }

        [JsonProperty("homepage" )]
        public string Homepage { get; set; }

        [JsonProperty("in_production" )]
        public bool InProduction { get; set; }

        [JsonProperty("languages" )]
        public IReadOnlyList<string> Languages { get; set; }

        [JsonProperty("last_air_date" )]
        public DateTime LastAirDate { get; set; }

        [JsonProperty("name" )]
        public string Name { get; set; }

        [JsonProperty("networks" )]
        public IReadOnlyList<Network> Networks { get; set; }

        [JsonProperty("number_of_episodes" )]
        public int NumberOfEpisodes { get; set; }

        [JsonProperty("number_of_seasons" )]
        public int NumberOfSeasons { get; set; }

        [JsonProperty("origin_country" )]
        public IReadOnlyList<string> OriginCountry { get; set; }

        [JsonProperty("original_language" )]
        public string OriginalLanguage { get; set; }

        [JsonProperty("original_name" )]
        public string OriginalName { get; set; }

        [JsonProperty("overview" )]
        public string Overview { get; set; }

        [JsonProperty("popularity" )]
        public double Popularity { get; set; }

        [JsonProperty("poster_path" )]
        public string PosterPath { get; set; }

        [JsonProperty("production_companies" )]
        public IReadOnlyList<ProductionCompanyInfo> ProductionCompanies { get; set; }

        [JsonProperty("seasons" )]
        public IReadOnlyList<Season> Seasons { get; set; }

        [JsonProperty("keywords" )]
        [JsonConverter( typeof( KeywordConverter ), "results" )]
        public IReadOnlyList<Keyword> Keywords { get; set; }

        public TVShow()
        {
            CreatedBy = new TVShowCreator[0];
            EpisodeRunTime = new int[0];
            Genres = new Genre[0];
            Languages = new string[0];
            Networks = new Network[0];
            OriginCountry = new string[0];
            ProductionCompanies = new ProductionCompanyInfo[0];
            Seasons = new Season[0];
            Keywords = new Keyword[0];
        }

        public override string ToString()
            => $"{Name} ({FirstAirDate:yyyy-MM-dd}) [{Id}]";
    }
}
