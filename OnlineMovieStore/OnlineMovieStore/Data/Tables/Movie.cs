using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Data.Tables
{
    public class Movie
    {
        public Movie()
        {
            /*   Cagetories = new HashSet<MovieCategory>();
               MovieDirectors = new HashSet<MovieDirector>();
               MovieWriters = new HashSet<MovieWriter>();*/
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        [Required]
        public string Title { get; set; }
        // public ICollection<MovieCategory> Cagetories { get; set; }
        [Required]
        public int RuntimeMinutes { get; set; }
        [Required]
        public int StartYear { get; set; }
        // public ICollection<MovieDirector> MovieDirectors { get; set; }
        //  public ICollection<MovieWriter> MovieWriters { get; set; }
        public string Description { get; set; }
        public int RatingId { get; set; }
        public MovieRating Rating { get; set; }
    }
}
