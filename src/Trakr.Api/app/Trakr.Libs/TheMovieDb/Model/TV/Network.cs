﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Trakr.Libs.TheMovieDb.Model.TV
{
    
    public class Network : IEqualityComparer<Network>
    {
        [JsonProperty("id" )]
        public int Id { get; set; }

        [JsonProperty("name" )]
        public string Name { get; set; }

        public Network( int id, string name )
        {
            Id = id;
            Name = name;
        }

        public bool Equals( Network x, Network y )
            => x.Id == y.Id && x.Name == y.Name;

        public int GetHashCode( Network obj )
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
            var network = obj as Network;
            if( network == null )
            {
                return false;
            }

            return Equals( this, network );
        }

        public override int GetHashCode()
            => GetHashCode( this );

        public override string ToString()
            => $"{Name} ({Id})";
    }
}