using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieStore.Data.Tables
{
    [Table("AspNetUsers")]
    public class User: IdentityUser
    {
        public User()
        {
            
        }
    }
}
