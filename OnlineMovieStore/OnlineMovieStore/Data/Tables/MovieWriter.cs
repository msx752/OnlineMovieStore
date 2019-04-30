using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Data.Tables
{
    public class MovieWriter
    {
        [Key]
        public int Id { get; set; }
        public string MovieId { get; set; }
        public Movie Movie { get; set; }
        public string WriterId { get; set; }
        public Writer Writer { get; set; }
    }
}
