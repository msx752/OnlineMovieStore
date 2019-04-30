using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineMovieStore.Data.Tables;
using OnlineMovieStore.Models;
using OnlineMovieStore.Repositories;

namespace OnlineMovieStore.Controllers
{
    public class HomeController : Controller
    {
        public IDataRepository<Movie> MovieRepo { get; set; }
        public HomeController(IDataRepository<Movie> _movieRepo)
        {
            MovieRepo = _movieRepo;
        }
        public IActionResult Index()
        {
            return View(MovieRepo.GetAll());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
