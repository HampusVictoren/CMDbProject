using CMDb___project.Models.ViewModels;
using CMDb___project.Models.Dtos;
using CMDb___project.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb___project.Controllers
{
    public class HomeController : Controller
    {
            private IRepository repository;
            public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        //Eventuellt i egen mapp senare
         public async Task<IActionResult> Index()
        {
            GetMovieDto[] cmdbmovies;
            MovieDto[] omdbmovies = new MovieDto[6];
            cmdbmovies = await repository.GetCmdbMoviesAsync();
            for (int i = 0; i < cmdbmovies.Length-1; i++)
            {
                await Task.Run(
                    async() =>
                    {
                        string movieid = cmdbmovies[i].imdbID;
                        omdbmovies[i] = await repository.GetOmdbMoviesAsync(movieid);
                    }
                );
            }

        return View(omdbmovies);
        }

        public IActionResult Details()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
