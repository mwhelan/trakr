using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Trakr.Libs.TheMovieDb.Model.Genres;

namespace Trakr.Libs.TheMovieDb.Model.People
{
    public enum MediaType
    {
        Unknown,
        Movie,
        TV,
    }

    
    public class PersonInfo
    {
        // TODO: (K. Chase) [2016-07-10] Update all POCO's to explicity name the Id property, i.e,. PersonId, MovieId, TVShowId.
        [JsonProperty("id" )]
        public int Id { get; set; }

        [JsonProperty("name" )]
        public string Name { get; set; }

        [JsonProperty("adult" )]
        public bool IsAdultFilmStar { get; set; }

        [JsonProperty("known_for" )]
        public IReadOnlyList<PersonInfoRole> KnownFor { get; set; }

        [JsonProperty("profile_path" )]
        public string ProfilePath { get; set; }

        [JsonProperty("popularity" )]
        public double Popularity { get; set; }

        public PersonInfo()
        {
            KnownFor = new PersonInfoRole[0];
        }

        public override string ToString()
            => $"{Name} ({Id})";
    }

    
    public class PersonInfoRole
    {
        // TODO: (K. Chase) [2016-07-10] Break into type for Movie and TV w/ a custom serializer.
        // re: see TVShowName v MovieTitle (and related)

        /// <summary>
        /// The MovieId or TVShowId as defined by the value of <see cref="MediaType"/>.
        /// </summary>
        [JsonProperty("id" )]
        public int Id { get; set; }

        [JsonProperty("media_type" )]
        public MediaType MediaType { get; set; }

        /// <summary>
        /// Only populated when <see cref="MediaType"/> is TV.
        /// </summary>
        [JsonProperty("name" )]
        public string TVShowName { get; set; }

        /// <summary>
        /// Only populated when <see cref="MediaType"/> is TV.
        /// </summary>
        [JsonProperty("original_name" )]
        public string TVShowOriginalName { get; set; }

        /// <summary>
        /// Only populated when <see cref="MediaType"/> is Movie.
        /// </summary>
        [JsonProperty("title" )]
        public string MovieTitle { get; set; }

        /// <summary>
        /// Only populated when <see cref="MediaType"/> is Movie.
        /// </summary>
        [JsonProperty("original_title" )]
        public string MovieOriginalTitle { set; get; }

        [JsonProperty("backdrop_path" )]
        public string BackdropPath { get; set; }

        [JsonProperty("poster_path" )]
        public string PosterPath { get; set; }

        /// <summary>
        /// Only populated when <see cref="MediaType"/> is Movie.
        /// </summary>
        [JsonProperty("release_date" )]
        public DateTime MovieReleaseDate { get; set; }

        /// <summary>
        /// Only populated when <see cref="MediaType"/> is TV.
        /// </summary>
        [JsonProperty("first_air_date" )]
        public DateTime TVShowFirstAirDate { get; set; }

        [JsonProperty("overview" )]
        public string Overview { get; set; }

        [JsonProperty("adult" )]
        public bool IsAdultThemed { get; set; }

        [JsonProperty("video" )]
        public bool IsVideo { get; set; }

        [JsonProperty("genre_ids" )]
        internal IReadOnlyList<int> GenreIds { get; set; }

        public IReadOnlyList<Genre> Genres { get; set; }

        [JsonProperty("original_language" )]
        public string OriginalLanguage { get; set; }

        [JsonProperty("popularity" )]
        public double Popularity { get; set; }

        [JsonProperty("vote_count" )]
        public int VoteCount { get; set; }

        [JsonProperty("vote_average" )]
        public double VoteAverage { get; set; }

        [JsonProperty("origin_country" )]
        public IReadOnlyList<string> OriginCountry { get; set; }

        public PersonInfoRole()
        {
            GenreIds = new int[0];
            Genres = new Genre[0];
            OriginCountry = new string[0];
        }

        public override string ToString()
        {
            return MediaType == MediaType.Movie
                ? $"Movie: {MovieTitle} ({Id} - {MovieReleaseDate:yyyy-MM-dd})"
                : $"TV: {TVShowName} ({Id} - {TVShowFirstAirDate:yyyy-MM-dd})";
        }
    }
}
