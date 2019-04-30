using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Data.Tables
{
    public class MovieDirector
    {
        public string MovieId { get; set; }
        public Movie Movie { get; set; }
        public string DirectorId { get; set; }
        public Director Director { get; set; }
    }
}
