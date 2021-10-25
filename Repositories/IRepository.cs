
using CMDb___project.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb___project.Repositories
{
    public interface IRepository
    {
        /// <Movie>
        /// Retrieves a Movie
        /// </Movie>
        /// <returns></returns>
        /// 
        Task<MovieDto[]> GetMoviesAsync();
        Task<GetMovieDto[]> GetCmdbMoviesAsync();
        Task<MovieDto> GetOmdbMoviesAsync(string movieId);

        Task<MovieDto> GetMovieDetails(string imdbid);
        //Task<IEnumerable<MovieDto>> GetMovie(string id);
    }
}