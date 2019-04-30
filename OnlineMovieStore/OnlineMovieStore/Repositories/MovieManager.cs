using Microsoft.EntityFrameworkCore;
using OnlineMovieStore.Data;
using OnlineMovieStore.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Repositories
{
    public class MovieManager : IDataRepository<Movie>
    {
        readonly ApplicationDbContext _context;
        public MovieManager(ApplicationDbContext context)
        {
            _context = context;
        }
        public Movie Get(string id)
        {
            return _context.Movies
                .Include(f=>f.Categories)
                .Include(f=>f.Rating)
                .Include(f => f.MovieDirectors)
                .Include(f => f.MovieWriters)
                .FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return _context.Movies
                .Include(f => f.Categories)
                .Include(f => f.Rating)
                .Include(f => f.MovieDirectors)
                .Include(f => f.MovieWriters)
                .ToList();
        }
        public void Update(Movie dbEntity, Movie newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
