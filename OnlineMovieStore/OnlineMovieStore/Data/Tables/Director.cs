using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Data.Tables
{
    public class Director
    {

        public Director()
        {
            MovieDirectors = new HashSet<MovieDirector>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        public string MovieId { get; set; }
        public string FullName { get; set; }
        public ICollection<MovieDirector> MovieDirectors { get; set; }
    }
}
