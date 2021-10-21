using CMDb___project.Infrastructure;
using CMDb___project.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb___project.Repositories
{
    public class Repository : IRepository
    {
        private readonly IApiClient apiClient;
        private readonly string omdbBaseEndpoint = "http://www.omdbapi.com/?apikey=c945b2b0&i=";
        private readonly string cmdbBaseEndpoint = "https://grupp9.dsvkurs.miun.se/api/movie";
        public Repository(IApiClient apiClient)
        {
            this.apiClient = apiClient;
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

        // public async Task<MovieDto> GetOmdbMoviesAsync(string movieId) =>  await apiClient.GetAsync<MovieDto>(omdbBaseEndpoint + movieId);
        
        // public async  Task<IEnumerable<MovieDto>> GetMovie(string id)
        //  =>  await apiClient.GetAsync<IEnumerable<MovieDto>>($"{omdbBaseEndpoint}/country/{countrySlug}/status/confirmed");

    }
}