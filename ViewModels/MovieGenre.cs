using Microsoft.AspNetCore.Mvc.Rendering;
using SampleMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMovie.ViewModels
{
    public class MovieGenre
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string SearchString { get; set; }
        public string Genre { get; set; }
    }
}
