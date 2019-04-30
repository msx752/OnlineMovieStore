using OnlineMovieStore.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Models
{
    public class FilteredViewModel
    {
        public string CategoryName { get; set; }
        public List<Movie> Filtered = new List<Movie>();
    }
}
