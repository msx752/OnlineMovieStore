using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Data.Tables
{
    public class PaymentHistory
    {
        public PaymentHistory()
        {
            TimeUtc = DateTimeOffset.UtcNow;
        }
        public string MovieId { get; set; }
        public Movie Movie { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public decimal PaidUsdPrice { get; set; }
        public DateTimeOffset TimeUtc { get; set; }
    }
}
