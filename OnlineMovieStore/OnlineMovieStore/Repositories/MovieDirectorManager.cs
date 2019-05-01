using Microsoft.EntityFrameworkCore;
using OnlineMovieStore.Data;
using OnlineMovieStore.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Repositories
{
    public class MovieDirectorManager : IDataRepository<MovieDirector>
    {
        readonly ApplicationDbContext _context;
        public MovieDirectorManager(ApplicationDbContext context)
        {
            _context = context;
        }
        public MovieDirector Get(object _id)
        {
            var id = (string)_id;
            return _context.MovieDirectors
                .Include(f=>f.Movie)
                .Include(f => f.Director)
                .FirstOrDefault(e => e.DirectorId == id);
        }
        public IEnumerable<MovieDirector> Get(string movieId)
        {
            return _context.MovieDirectors
                .Include(f => f.Movie)
                .Include(f => f.Director)
                .Where(f=>f.MovieId==movieId).ToList();
        }
        public IEnumerable<MovieDirector> GetAll()
        {
            return _context.MovieDirectors
                .Include(f => f.Movie)
                .Include(f => f.Director).ToList();
        }
        public void Update(MovieDirector dbEntity, MovieDirector newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
