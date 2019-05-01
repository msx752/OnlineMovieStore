using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineMovieStore.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return this.RedirectToAction("Basket");
        }
        public IActionResult Basket()
        {
            if (!User.Identity.IsAuthenticated)
                return this.Redirect("~/Identity/Account/Login");

            return View();
        }
    }
}