using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Data.Tables
{
    public class BasketMovies
    {
        public BasketMovies()
        {
            Ids = new List<string>();
        }
        public List<string> Ids { get; set; }
    }
    public class Basket
    {
        public Basket()
        {
            MovieIds = JsonConvert.SerializeObject(new BasketMovies());
        }
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public string MovieIds { get; set; }

        private BasketMovies _MovieIds = null;
        [NotMapped]
        public BasketMovies UserBasket
        {
            get
            {
                if (_MovieIds == null)
                    _MovieIds = JsonConvert.DeserializeObject<BasketMovies>(MovieIds);
                return _MovieIds;
            }
            set
            {
                _MovieIds = value;
                MovieIds = JsonConvert.SerializeObject(_MovieIds);
            }

        }
    }
}
