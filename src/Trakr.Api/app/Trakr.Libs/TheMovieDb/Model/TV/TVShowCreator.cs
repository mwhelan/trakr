﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Trakr.Libs.TheMovieDb.Model.TV
{
    
    public class TVShowCreator : IEqualityComparer<TVShowCreator>
    {
        [JsonProperty("id" )]
        public int Id { get; set; }

        [JsonProperty("name" )]
        public string Name { get; set; }

        [JsonProperty("profile_path" )]
        public string ProfilePath { get; set; }

        public TVShowCreator( int id, string name, string profilePath )
        {
            Id = id;
            Name = name;
            ProfilePath = profilePath;
        }

        public bool Equals( TVShowCreator x, TVShowCreator y )
            => x.Id == y.Id && x.Name == y.Name;

        public int GetHashCode( TVShowCreator obj )
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                hash = hash * 23 + obj.Id.GetHashCode();
                hash = hash * 23 + obj.Name.GetHashCode();
                return hash;
            }
        }

        public override bool Equals( object obj )
        {
            var showCreator = obj as TVShowCreator;
            if( showCreator == null )
            {
                return false;
            }

            return Equals( this, showCreator );
        }

        public override int GetHashCode()
            => GetHashCode( this );

        public override string ToString()
            => $"{Name} ({Id})";
    }
}