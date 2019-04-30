using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Data.Tables
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        public double AverageRating { get; set; }
        public int NumVotes { get; set; }
        public string MovieId { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
