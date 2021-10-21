using System;
namespace CMDb___project.Models.Dtos{

public class GetMovieDto
    {
        public string imdbID { get; set; }
        public int numberOfLikes { get; set; }
        public int numberOfDislikes { get; set; }
    }
}