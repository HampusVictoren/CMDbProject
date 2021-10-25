using CMDb___project.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb___project.Models.ViewModels
{
    public class DetailsViewModel
    {
        public MovieDto movie { get; set; }
        public DetailsViewModel(MovieDto selectedMovie)
        {
            movie = selectedMovie;
        }
    }
}
