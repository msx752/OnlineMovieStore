using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Data.Tables
{
    public class MovieCategory
    {
        public string MovieId { get; set; }
        public Movie Movie { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
