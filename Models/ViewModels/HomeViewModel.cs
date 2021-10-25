using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CMDb___project.Models.Dtos;

namespace CMDb___project.Models.ViewModels
{
    public class HomeViewModel
     {
        public MovieDto[] omdbmovies {get; set;}

        public HomeViewModel(MovieDto[] movies)
        {
            omdbmovies = movies;
        }
    }
}