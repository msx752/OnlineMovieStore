using Microsoft.EntityFrameworkCore;
using OnlineMovieStore.Data;
using OnlineMovieStore.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Repositories
{
    public class CategoryManager : IDataRepository<Category>
    {
        readonly ApplicationDbContext _context;
        public CategoryManager(ApplicationDbContext context)
        {
            _context = context;
        }
        public Category Get(object _id)
        {
            var id = (int)_id;
            return _context.Categories
                .FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
        public void Update(Category dbEntity, Category newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
