using OnlineMovieStore.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Models
{
    public class MovieViewModel
    {
        public List<Movie> HighRatings = new List<Movie>();
        public List<Movie> All = new List<Movie>();
        public List<Movie> RecentlyAdded = new List<Movie>();
    }
}
