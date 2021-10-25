using CMDb___project.Infrastructure;
using CMDb___project.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMDb___project.Controllers;

namespace CMDb___project.Repositories
{
    public class Repository : IRepository
    {
        private readonly IApiClient apiClient;
        private readonly string omdbBaseEndpoint = "http://www.omdbapi.com/?apikey=c945b2b0&i=";
        private readonly string cmdbBaseEndpoint = "https://grupp9.dsvkurs.miun.se/api/Toplist";
        public MovieDto[] omdbmovies { get; set; }
        
        public Repository(IApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<MovieDto[]> GetMoviesAsync()
        {
            GetMovieDto[] cmdbmovies;
            omdbmovies = new MovieDto[4];
            cmdbmovies = await GetCmdbMoviesAsync();

            for (int i = 0; i < omdbmovies.Length; i++)
            {
                await Task.Run(
                    async () =>
                    {
                        string movieid = cmdbmovies[i].imdbID;
                        omdbmovies[i] = await GetOmdbMoviesAsync(movieid);
                        omdbmovies[i].PlotTrimmed = omdbmovies[i].Plot.Substring(0, 40);
                    }
                );
            }

            return omdbmovies;
        }

        public async Task<GetMovieDto[]> GetCmdbMoviesAsync()
        {
            var result = await apiClient.GetAsync<GetMovieDto[]>(cmdbBaseEndpoint);
            return result;
        }

        public async Task<MovieDto> GetOmdbMoviesAsync(string movieId)
        {

            var result = await apiClient.GetAsync<MovieDto>(omdbBaseEndpoint + movieId);
            return result;
        }

        public MovieDto GetMovieDetails(string imdbid)
        {
            for (int i = 0; i < omdbmovies.Length; i++)
            {
                if (omdbmovies[i].imdbID == imdbid)
                {
                    return omdbmovies[i];
                }
            }
            return null;
        }
    }
}