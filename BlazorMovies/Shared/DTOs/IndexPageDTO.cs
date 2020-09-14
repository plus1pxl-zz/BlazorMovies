using System;
using System.Collections.Generic;
using System.Text;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Shared.DTOs
{
    public class IndexPageDTO
    {
        public List<Movie> InTheaters { get; set; }

        public List<Movie> UpcomingReleases { get; set; }
    }
}
