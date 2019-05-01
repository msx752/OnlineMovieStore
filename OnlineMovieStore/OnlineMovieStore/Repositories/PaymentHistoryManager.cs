﻿using Microsoft.EntityFrameworkCore;
using OnlineMovieStore.Data;
using OnlineMovieStore.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Repositories
{
    public class PaymentHistoryManager : IDataRepository<PaymentHistory>
    {
        readonly ApplicationDbContext _context;
        public PaymentHistoryManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public PaymentHistory Add(PaymentHistory newPayment)
        {
            var bst = _context.Payments.Add(newPayment);
            SaveChanges();
            return bst.Entity;
        }
        public IEnumerable<PaymentHistory> Get(string userId)
        {
            return _context.Payments
                .Include(f => f.Movie)
                .Include(f => f.User)
                .Where(f => f.UserId == userId).ToList();
        }
        public IEnumerable<PaymentHistory> GetAll()
        {
            return _context.Payments
                .Include(f => f.Movie)
                .Include(f => f.User).ToList();
        }
        public void Update(PaymentHistory dbEntity, PaymentHistory newEntity)
        {
            throw new NotImplementedException();
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public PaymentHistory Get(object _id)
        {
            throw new NotImplementedException();
        }
    }
}
