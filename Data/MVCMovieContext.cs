using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleMovie.Models;

namespace SampleMovie.Data
{
    public class MVCMovieContext : DbContext
    {
        public MVCMovieContext (DbContextOptions<MVCMovieContext> options)
            : base(options)
        {
        }

        public DbSet<SampleMovie.Models.Movie> Movie { get; set; }
    }
}
