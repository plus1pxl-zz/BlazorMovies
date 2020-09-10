﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Helpers
{
    interface IRepository
    {
        List<Movie> GetMovies();
    }
}
