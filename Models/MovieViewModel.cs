using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb___project.Models
{
    public class MovieViewModel
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

        public List<MovieViewModel> GetMovieList()
        {

            var movies = new List<MovieViewModel>
            {
                new MovieViewModel
                {
                    Id = "tt0162222",
                    Title = "Cast Away",
                    Poster = "https://m.media-amazon.com/images/M/MV5BN2Y5ZTU4YjctMDRmMC00MTg4LWE1M2MtMjk4MzVmOTE4YjkzXkEyXkFqcGdeQXVyNTc1NTQxODI@._V1_SX300.jpg",
                    Plot = "A FedEx executive undergoes a physical and emotional transformation after crash landing on a deserted island.",
                    Year = 2000,
                    Actors = "Tom Hanks, Helen Hunt, Paul Sanchez",
                    Director = "Robert Zemeckis",
                    IMDbRating = 7.8,
                    CMDbRating = 10
                },
                new MovieViewModel
                {
                    Id = "tt0117951",
                    Title = "Trainspotting",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMzA5Zjc3ZTMtMmU5YS00YTMwLWI4MWUtYTU0YTVmNjVmODZhXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg",
                    Plot = "Renton, deeply immersed in the Edinburgh drug scene, tries to clean up and get out, despite the allure of the drugs and influence of friends.",
                    Year = 1996,
                    Actors = "Ewan McGregor, Ewen Bremner, Jonny Lee Miller",
                    Director = "Danny Boyle",
                    IMDbRating = 8.1,
                    CMDbRating = 7.2
                },
                new MovieViewModel
                {
                    Id = "tt0241527",
                    Title = "Harry Potter and the Sorcerer's Stone",
                    Poster = "https://m.media-amazon.com/images/M/MV5BNjQ3NWNlNmQtMTE5ZS00MDdmLTlkZjUtZTBlM2UxMGFiMTU3XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_SX300.jpg",
                    Plot = "An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family and the terrible evil that haunts the magical world.",
                    Year = 2001,
                    Actors = "Daniel Radcliffe, Rupert Grint, Richard Harris",
                    Director = "Chris Columbus",
                    IMDbRating = 7.6,
                    CMDbRating = 6.2
                },
                new MovieViewModel
                {
                    Id = "tt0120737",
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    Poster = "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_SX300.jpg",
                    Plot = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                    Year = 2001,
                    Actors = "Elijah Wood, Ian McKellen, Orlando Bloom",
                    Director = "Peter Jackson",
                    IMDbRating = 8.8,
                    CMDbRating = 5.5
                }
            };

            return movies;
        }
    }
}
