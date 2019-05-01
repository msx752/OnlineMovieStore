using Microsoft.EntityFrameworkCore;
using OnlineMovieStore.Data;
using OnlineMovieStore.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Repositories
{
    public class UserManager : IDataRepository<User>
    {
        readonly ApplicationDbContext _context;
        public UserManager(ApplicationDbContext context)
        {
            _context = context;
        }
        public User Get(object _id)
        {
            var id = _id.ToString();
            return _context.Users
                .Include(f=>f.Basket)
                .FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users
                .Include(f => f.Basket)
                .ToList();
        }
        public void Update(User dbEntity, User newEntity)
        {
            throw new NotImplementedException();
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
