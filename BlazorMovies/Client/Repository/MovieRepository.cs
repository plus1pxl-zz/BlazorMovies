using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared.DTOs;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Repository
{
    public class MovieRepository: IMovieRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/movies";

        public MovieRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<IndexPageDTO> GetIndexPageDTO()
        {
            var response = await httpService.Get<IndexPageDTO>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<int> CreateMovie(Movie movie)
        {
            var response = await httpService.Post<Movie, int>(url, movie);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public Task DeleteMovie(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
