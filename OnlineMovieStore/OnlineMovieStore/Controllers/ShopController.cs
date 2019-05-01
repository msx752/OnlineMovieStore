using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineMovieStore.Data.Tables;
using OnlineMovieStore.Repositories;

namespace OnlineMovieStore.Controllers
{
    public class ShopController : Controller
    {
        public BasketManager BasketRepo { get; set; }
        public UserManager UserRepo { get; set; }
        public ShopController(BasketManager _basketRepo, UserManager _userRepo)
        {
            BasketRepo = _basketRepo;
            UserRepo = _userRepo;
        }
        public IActionResult Index()
        {
            return this.RedirectToAction("Basket");
        }
        public IActionResult Basket()
        {
            if (!User.Identity.IsAuthenticated)
                return this.Redirect("~/Identity/Account/Login");
            var id = User.GetUserId();
            User user = UserRepo.Get(id);
            if (user.Basket == null)
            {
                user.Basket = new Basket();
                UserRepo.SaveChanges();
            }
            return View(user.Basket);
        }
    }
}