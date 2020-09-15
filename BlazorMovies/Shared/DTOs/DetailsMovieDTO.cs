using System;
using System.Collections.Generic;
using System.Text;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Shared.DTOs
{
    public class DetailsMovieDTO
    {
        public Movie Movie { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Person> Actors { get; set; }
    }
}
