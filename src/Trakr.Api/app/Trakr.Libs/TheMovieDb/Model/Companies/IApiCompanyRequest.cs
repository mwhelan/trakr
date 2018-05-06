using System.Threading.Tasks;
using Trakr.Libs.TheMovieDb.Model.ApiRequest;
using Trakr.Libs.TheMovieDb.Model.ApiResponse;

namespace Trakr.Libs.TheMovieDb.Model.Companies
{
    /// <summary>
    /// Interface for retrieving information about a production company.
    /// </summary>
    public interface IApiCompanyRequest : IApiRequest
    {
        /// <summary>
        /// Gets all the basic information about a specific company.
        /// </summary>
        /// <param name="companyId">The company Id is typically found from a Movie or TV query.</param>
        Task<ApiQueryResponse<ProductionCompany>> FindByIdAsync( int companyId );
    }
}
