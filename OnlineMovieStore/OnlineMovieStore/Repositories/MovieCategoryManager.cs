using Microsoft.EntityFrameworkCore;
using OnlineMovieStore.Data;
using OnlineMovieStore.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Repositories
{
    public class MovieCategoryManager : IDataRepository<MovieCategory>
    {
        readonly ApplicationDbContext _context;
        public MovieCategoryManager(ApplicationDbContext context)
        {
            _context = context;
        }
        public MovieCategory Get(object _id)
        {
            var id = (int)_id;
            return _context.MovieCategories
                .Include(f=>f.Movie)
                .Include(f => f.Category)
                .FirstOrDefault(e => e.CategoryId == id);
        }
        public IEnumerable<MovieCategory> Get(string movieId)
        {
            return _context.MovieCategories
                .Include(f => f.Movie)
                .Include(f => f.Category)
                .Where(f=>f.MovieId==movieId).ToList();
        }
        public IEnumerable<MovieCategory> GetAll()
        {
            return _context.MovieCategories
                .Include(f => f.Movie)
                .Include(f => f.Category).ToList();
        }
        public void Update(MovieCategory dbEntity, MovieCategory newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
