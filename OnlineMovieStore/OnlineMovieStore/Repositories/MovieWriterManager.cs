using Microsoft.EntityFrameworkCore;
using OnlineMovieStore.Data;
using OnlineMovieStore.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Repositories
{
    public class MovieWriterManager : IDataRepository<MovieWriter>
    {
        readonly ApplicationDbContext _context;
        public MovieWriterManager(ApplicationDbContext context)
        {
            _context = context;
        }
        public MovieWriter Get(object _id)
        {
            var id = (string)_id;
            return _context.MovieWriters
                .Include(f => f.Movie)
                .Include(f => f.Writer)
                .FirstOrDefault(e => e.WriterId == id);
        }
        public IEnumerable<MovieWriter> Get(string movieId)
        {
            return _context.MovieWriters
                .Include(f => f.Movie)
                .Include(f => f.Writer)
                .Where(f => f.MovieId == movieId).ToList();
        }
        public IEnumerable<MovieWriter> GetAll()
        {
            return _context.MovieWriters
                .Include(f => f.Movie)
                .Include(f => f.Writer).ToList();
        }
        public void Update(MovieWriter dbEntity, MovieWriter newEntity)
        {
            throw new NotImplementedException();
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
