using System.Collections.Generic;
using Newtonsoft.Json;

// ReSharper disable UnusedAutoPropertyAccessor.Local

namespace Trakr.Libs.TheMovieDb.Model.ApiResponse
{
    /// <summary>
    /// Standard response from an API call returning a more than one result, i.e., a Search Result.
    /// Single item based results are returned with an 
    /// <see cref="ApiQueryResponse{T}"/>.
    /// </summary>
    
    public class ApiSearchResponse<T> : ApiResponseBase
    {
        /// <summary>
        /// The list of results from the search.
        /// </summary>
        [JsonProperty("results" )]
        public IReadOnlyList<T> Results { get; private set; }

        /// <summary>
        /// The current page number of the search result.
        /// </summary>
        [JsonProperty("page" )]
        public int PageNumber { get; private set; }

        /// <summary>
        /// The total number of pages found from the search result.
        /// </summary>
        [JsonProperty("total_pages" )]
        public int TotalPages { get; private set; }

        /// <summary>
        /// The total number of results from the search.
        /// </summary>
        [JsonProperty("total_results" )]
        public int TotalResults { get; private set; }

        public override string ToString()
            => $"Page {PageNumber} of {TotalPages} ({TotalResults} total results)";
    }
}
