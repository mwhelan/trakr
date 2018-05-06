using Newtonsoft.Json;

namespace Trakr.Libs.TheMovieDb.Model.Companies
{
    
    public class ParentCompany
    {
        [JsonProperty("id" )]
        public int Id { get; set; }

        [JsonProperty("name" )]
        public string Name { get; set; }

        [JsonProperty("logo_path" )]
        public string LogoPath { get; set; }

        public override string ToString()
        {
            if( string.IsNullOrWhiteSpace( Name ) )
            {
                return "n/a";
            }

            return $"{Name} ({Id})";
        }
    }
}
