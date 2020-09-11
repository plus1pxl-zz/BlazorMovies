using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Repository
{
    public class GenreRepository: IGenreRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/genres";

        public GenreRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreateGenre(Genre genre)
        {
            var response = await httpService.Post(url, genre);
            if (Equals(!response.Success))
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public Task<Genre> GetGenre(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Genre>> GetGenres()
        {
            throw new NotImplementedException();
        }

        public Task UpdateGenre(Genre genre)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGenre(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
