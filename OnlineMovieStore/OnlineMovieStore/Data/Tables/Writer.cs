using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Data.Tables
{
    public class Writer
    {
        public Writer()
        {
            MovieWriters = new HashSet<MovieWriter>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        public string FullName { get; set; }
        public ICollection<MovieWriter> MovieWriters { get; set; }
    }
}
