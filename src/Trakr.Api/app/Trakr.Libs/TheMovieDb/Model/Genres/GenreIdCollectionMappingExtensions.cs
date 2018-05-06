using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trakr.Libs.TheMovieDb.Model.People;
using Trakr.Libs.TheMovieDb.Model.TV;

namespace Trakr.Libs.TheMovieDb.Model.Genres
{
    internal static class GenreIdCollectionMappingExtensions
    {
        public static void PopulateGenres(this IEnumerable<TVShowInfo> tvShows, IApiGenreRequest api)
        {
            foreach (TVShowInfo tvShow in tvShows)
            {
                tvShow.Genres = MapGenreIdsToGenres(tvShow.GenreIds, api);
            }
        }

        public static void PopulateGenres(this IEnumerable<PersonInfo> people, IApiGenreRequest api)
        {
            foreach (PersonInfo person in people)
            {
                foreach (PersonInfoRole role in person.KnownFor)
                {
                    role.Genres = MapGenreIdsToGenres(role.GenreIds, api);
                }
            }
        }

        private static IReadOnlyList<Genre> MapGenreIdsToGenres(IEnumerable<int> genreIds, IApiGenreRequest api)
        {
            IReadOnlyList<Genre> genres = genreIds
                .Select(x => MapGenre(x, api))
                .ToList()
                .AsReadOnly();

            return genres;
        }

        private static Genre MapGenre(int genreId, IApiGenreRequest api)
        {
            Genre genre = api.AllGenres.FirstOrDefault(x => x.Id == genreId);

            if (genre == null)
            {
                genre = Task.Run(() => api.FindByIdAsync(genreId)).GetAwaiter().GetResult().Item;
            }

            return genre;
        }
    }
}
