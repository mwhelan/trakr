using Newtonsoft.Json;

namespace Trakr.Libs.TheMovieDb.Model.Companies
{
    
    public class ProductionCompany
    {
        [JsonProperty("id" )]
        public int Id { get; set; }

        [JsonProperty("name" )]
        public string Name { get; set; }

        [JsonProperty("description" )]
        public string Description { get; set; }

        [JsonProperty("headquarters" )]
        public string Headquarters { get; set; }

        [JsonProperty("homepage" )]
        public string Homepage { get; set; }

        [JsonProperty("logo_path" )]
        public string LogoPath { get; set; }

        [JsonProperty("parent_company" )]
        public ParentCompany ParentCompany { get; set; }

        public override string ToString()
            => $"{Name} ({Id})";
    }
}
