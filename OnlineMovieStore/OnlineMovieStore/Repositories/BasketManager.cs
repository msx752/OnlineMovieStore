using Microsoft.EntityFrameworkCore;
using OnlineMovieStore.Data;
using OnlineMovieStore.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Repositories
{
    public class BasketManager : IDataRepository<Basket>
    {
        readonly ApplicationDbContext _context;
        public BasketManager(ApplicationDbContext context)
        {
            _context = context;
        }
        public Basket Get(object _id)
        {
            var id = (int)_id;
            return _context.Baskets
                .Include(f=>f.User)
                .FirstOrDefault(e => e.Id == id);
        }
        public Basket Get(string userId)
        {
            return _context.Baskets
                .Include(f => f.User)
                .FirstOrDefault(e => e.UserId == userId);
        }

        public IEnumerable<Basket> GetAll()
        {
            return _context.Baskets
                .Include(f => f.User)
                .ToList();
        }
        public void Update(Basket dbEntity, Basket newEntity)
        {
            throw new NotImplementedException();
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
