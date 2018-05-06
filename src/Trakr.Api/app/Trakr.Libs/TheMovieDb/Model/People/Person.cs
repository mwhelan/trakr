using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Trakr.Libs.TheMovieDb.Model.People
{
    
    public class Person
    {
        [JsonProperty("id" )]
        public int Id { get; set; }

        [JsonProperty("name" )]
        public string Name { get; set; }

        [JsonProperty("also_known_as" )]
        public IReadOnlyList<string> AlsoKnownAs { get; set; }

        [JsonProperty("adult" )]
        public bool IsAdultFilmStar { get; set; }

        [JsonProperty("biography" )]
        public string Biography { get; set; }

        [JsonProperty("birthday" )]
        public DateTime Birthday { get; set; }

        [JsonProperty("deathday" )]
        public DateTime? Deathday { get; set; }

        [JsonProperty("gender" )]
        public Gender Gender { get; set; }

        [JsonProperty("homepage" )]
        public string Homepage { get; set; }

        [JsonProperty("imdb_id" )]
        public string ImdbId { get; set; }

        [JsonProperty("place_of_birth" )]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("popularity" )]
        public double Popularity { get; set; }

        [JsonProperty("profile_path" )]
        public string ProfilePath { get; set; }

        public Person()
        {
            AlsoKnownAs = new string[0];
        }

        public override string ToString()
            => Name;
    }
}
