using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Refit;
using Trakr.Libs.TvMaze.Models;

namespace Trakr.Libs.TvMaze
{
    public class TvMazeClient : ITvMaze
    {
        private readonly ILogger<TvMazeClient> _logger;
        private readonly ITvMaze _client;

        public TvMazeClient(ILogger<TvMazeClient> logger)
        {
            _logger = logger;
            _client = RestService.For<ITvMaze>("http://api.tvmaze.com/");
        }

        public Task<List<ShowSearchResult>> ShowSearch(string showName)
        {
            _logger.LogDebug("ShowSearch {showName}");
            return _client.ShowSearch(showName);
        }

        public Task<Show> GetShowBasic(string showName)
        {
            _logger.LogDebug("GetShowBasic {showName}");
            return _client.GetShowBasic(showName);
        }

        public Task<Show> GetShowWithEpisodes(string showName)
        {
            _logger.LogDebug("GetShowWithEpisodes {showName}");
            return _client.GetShowWithEpisodes(showName);
        }
    }
}