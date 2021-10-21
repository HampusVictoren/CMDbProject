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

         public string[] movieTitle = new string[6];
         public string[] moviePoster = new string[6];
         public string[] moviePlot = new string[6];
         public string[] movieDirector = new string[6];
         public string[] movieActors = new string[6];

        public MovieDto[] movies = new MovieDto[6];

        public HomeViewModel(MovieDto[] movies)
        {

            movieTitle[0] = movies[0].Title;
            moviePoster[0] = movies[0].Poster;
            moviePlot[0] = movies[0].Plot;
            movieDirector[0] = movies[0].Director;
            movieActors[0] = movies[0].Actors;

            // TotalConfirmed = summary.Global.TotalConfirmed;
            // var query = summary.Countries
            // .Where(x => x.Slug=="sweden")
            // .FirstOrDefault();

            // TotalConfirmedSweden = query.TotalConfirmed;


        }
    }
}