using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Trakr.Libs.TheMovieDb.Model.People
{
    
    public class PersonTVCredit
    {
        [JsonProperty("id" )]
        public int PersonId { get; set; }

        [JsonProperty("cast" )]
        public IReadOnlyList<PersonTVCastMember> CastRoles { get; set; }

        [JsonProperty("crew" )]
        public IReadOnlyList<PersonTVCrewMember> CrewRoles { get; set; }

        public PersonTVCredit()
        {
            CastRoles = new PersonTVCastMember[0];
            CrewRoles = new PersonTVCrewMember[0];
        }
    }

    
    public class PersonTVCastMember
    {
        [JsonProperty("id" )]
        public int TVShowId { get; set; }

        [JsonProperty("character" )]
        public string Character { get; set; }

        [JsonProperty("credit_id" )]
        public string CreditId { get; set; }

        [JsonProperty("episode_count" )]
        public int EpisodeCount { get; set; }

        [JsonProperty("first_air_date" )]
        public DateTime FirstAirDate { get; set; }

        [JsonProperty("name" )]
        public string Name { get; set; }

        [JsonProperty("original_name" )]
        public string OriginalName { get; set; }

        [JsonProperty("poster_path" )]
        public string PosterPath { get; set; }
    }

    
    public class PersonTVCrewMember
    {
        [JsonProperty("id" )]
        public int TVShowId { get; set; }

        [JsonProperty("credit_id" )]
        public string CreditId { get; set; }

        [JsonProperty("department" )]
        public string Department { get; set; }

        [JsonProperty("episode_count" )]
        public int EpisodeCount { get; set; }

        [JsonProperty("first_air_date" )]
        public DateTime FirstAirDate { get; set; }

        [JsonProperty("job" )]
        public string Job { get; set; }

        [JsonProperty("name" )]
        public string Name { get; set; }

        [JsonProperty("original_name" )]
        public string OriginalName { get; set; }

        [JsonProperty("poster_path" )]
        public string PosterPath { get; set; }
    }
}
