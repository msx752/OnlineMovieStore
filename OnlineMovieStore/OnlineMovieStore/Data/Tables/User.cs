using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Data.Tables
{
    [Table("AspNetUsers")]
    public class User : IdentityUser
    {
        public User()
        {

        }
        private Basket _basket = null;
        public Basket Basket
        {
            get
            {
                if (_basket == null)
                {
                    _basket = new Basket();
                }
                return _basket;
            }
            set
            {
                _basket = value;
            }
        }
    }
}
