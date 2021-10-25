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
            var model = new HomeViewModel(await repository.GetMoviesAsync());
            return View(model);
        }

        public async Task<IActionResult> Details(string imdbid)
        {
            var model = new DetailsViewModel(await repository.GetMovieDetails(imdbid));
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
