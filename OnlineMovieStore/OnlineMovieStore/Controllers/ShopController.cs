using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineMovieStore.Data.Tables;
using OnlineMovieStore.Repositories;

namespace OnlineMovieStore.Controllers
{
    public class ShopController : Controller
    {
        public PaymentHistoryManager PaymentRepo { get; set; }
        public MovieManager MovieRepo { get; set; }
        public BasketManager BasketRepo { get; set; }
        public UserManager UserRepo { get; set; }
        public ShopController(BasketManager _basketRepo, UserManager _userRepo, MovieManager _movieRepo, PaymentHistoryManager _paymentRepo)
        {
            BasketRepo = _basketRepo;
            UserRepo = _userRepo;
            MovieRepo = _movieRepo;
            PaymentRepo = _paymentRepo;
        }
        public IActionResult Index()
        {
            return this.RedirectToAction("Basket");
        }
        [Authorize]
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
            List<Movie> movies = new List<Movie>();
            foreach (var item in user.Basket.UserBasket.Ids)
            {
                movies.Add(MovieRepo.Get(item));
            }
            return View(movies);
        }
        [Authorize]
        public IActionResult RemoveFromBasket(string Id)
        {
            var movie = MovieRepo.Get(Id);
            if (movie == null)
            {
                return NotFound();
            }
            var usrBasket = BasketRepo.Get(User.GetUserId());
            if (usrBasket.UserBasket.Ids.Contains(Id))
            {
                usrBasket.UserBasket.Ids.Remove(Id);
                usrBasket.UserBasket = usrBasket.UserBasket;
                BasketRepo.SaveChanges();
            }
            return this.RedirectToAction("Basket");
        }
        [Authorize]
        public IActionResult AddToBasket(string Id)
        {
            var movie = MovieRepo.Get(Id);
            if (movie == null)
            {
                return NotFound();
            }
            var usrBasket = BasketRepo.Get(User.GetUserId());
            if (!usrBasket.UserBasket.Ids.Contains(Id))
            {
                usrBasket.UserBasket.Ids.Add(Id);
                usrBasket.UserBasket = usrBasket.UserBasket;
                BasketRepo.SaveChanges();
            }
            return this.RedirectToAction("Basket");
        }
        [Authorize]
        public IActionResult PaymentHistory()
        {
            return View();
        }
        [Authorize]
        public IActionResult BuyAll()
        {
            return this.RedirectToAction("PaymentHistory");
        }
        [Authorize]
        public IActionResult Buy(string Id)
        {
            var movie = MovieRepo.Get(Id);
            if (movie == null)
            {
                return NotFound();
            }
            PaymentRepo.Get(User.GetUserId());
            return this.RedirectToAction("PaymentHistory");
        }
    }
}