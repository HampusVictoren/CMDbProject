using System;
namespace CMDb___project.Models.Dtos
{
    public class MovieDto
    {
         public string Id { get; set; }
        public string Title { get; set; }
        public string Poster { get; set; }
        public string Plot { get; set; }
        public int Year { get; set; }
        public string Actors { get; set; }
        public string Director { get; set; }
        public double IMDbRating { get; set; }
        public double CMDbRating { get; set; }

    }
}