using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using Trakr.Libs.TvMaze.Models;

namespace Trakr.Libs.TvMaze
{
    public interface ITvMaze
    {
        //URL: /search/shows? q=query
        //Example: http://api.tvmaze.com/search/shows?q=girls
        [Get("/search/shows/?q={showName}")]
        Task<List<ShowSearchResult>> ShowSearch(string showName);

        //URL: /singlesearch/shows? q=query
        //Example: http://api.tvmaze.com/singlesearch/shows?q=girls
        [Get("/singlesearch/shows/?q={showName}")]
        Task<Show> GetShowBasic(string showName);

        //URL: /singlesearch/shows? q=query&embed=episodes
        //Example: http://api.tvmaze.com/singlesearch/shows?q=girls&embed=episodes
        [Get("/singlesearch/shows/?q={showName}&embed=episodes")]
        Task<Show> GetShowWithEpisodes(string showName);
    }
}
