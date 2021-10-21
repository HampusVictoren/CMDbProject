
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
        /// Retrieves a covid Movie
        /// </Movie>
        /// <returns></returns>
        Task<GetMovieDto[]> GetCmdbMoviesAsync();
        Task<MovieDto> GetOmdbMoviesAsync(string movieId);
        //Task<IEnumerable<MovieDto>> GetMovie(string id);
    }
}