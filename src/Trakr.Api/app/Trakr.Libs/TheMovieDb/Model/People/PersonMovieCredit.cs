using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Trakr.Libs.TheMovieDb.Model.People
{
    
    public class PersonMovieCredit
    {
        [JsonProperty("id" )]
        public int PersonId { get; set; }

        [JsonProperty("cast" )]
        public IReadOnlyList<PersonMovieCastMember> CastRoles { get; set; }

        [JsonProperty("crew" )]
        public IReadOnlyList<PersonMovieCrewMember> CrewRoles { get; set; }

        public PersonMovieCredit()
        {
            CastRoles = new PersonMovieCastMember[0];
            CrewRoles = new PersonMovieCrewMember[0];
        }
    }

    
    public class PersonMovieCastMember
    {
        [JsonProperty("id" )]
        public int MovieId { get; set; }

        [JsonProperty("adult" )]
        public bool IsAdultThemed { get; set; }

        [JsonProperty("character" )]
        public string Character { get; set; }

        [JsonProperty("credit_id" )]
        public string CreditId { get; set; }

        [JsonProperty("original_title" )]
        public string OriginalTitle { get; set; }

        [JsonProperty("poster_path" )]
        public string PosterPath { get; set; }

        [JsonProperty("release_date" )]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty("title" )]
        public string Title { get; set; }
    }

    
    public class PersonMovieCrewMember
    {
        [JsonProperty("id" )]
        public int MovieId { get; set; }

        [JsonProperty("adult" )]
        public bool IsAdultThemed { get; set; }

        [JsonProperty("credit_id" )]
        public string CreditId { get; set; }

        [JsonProperty("department" )]
        public string Department { get; set; }

        [JsonProperty("job" )]
        public string Job { get; set; }

        [JsonProperty("original_title" )]
        public string OriginalTitle { get; set; }

        [JsonProperty("poster_path" )]
        public string PosterPath { get; set; }

        [JsonProperty("release_date" )]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty("title" )]
        public string Title { get; set; }
    }
}
