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
    public class MovieController : Controller
    {
        public MovieManager MovieRepo { get; set; }
        public CategoryManager CatRepo { get; set; }
        public MovieController(MovieManager _movieRepo, CategoryManager _catRepo)
        {
            MovieRepo = _movieRepo;
            CatRepo = _catRepo;
        }
        public IActionResult Index()
        {
            IndexViewModel viewModel = new IndexViewModel();
            viewModel.HighRatings = MovieRepo.GetAll().Where(f => f.Rating.AverageRating >= 70).Take(5).ToList();
            viewModel.All = MovieRepo.GetAll().ToList();
            viewModel.RecentlyAdded = MovieRepo.GetAll().Take(4).ToList();
            return View("index", viewModel);
        }
        public IActionResult HighRatings()
        {
            return View(MovieRepo.GetAll().Where(f => f.Rating.AverageRating >= 70).Take(5).ToList());
        }
        public IActionResult RecentlyAdded()
        {
            return View(MovieRepo.GetAll().Take(4).ToList());
        }

        [Route("Movie/{Id}")]
        public IActionResult Detail(string Id)
        {
            DetailViewModel detail = new DetailViewModel();
            detail.Movie = MovieRepo.Get(Id);
            return View(detail);
        }
        public IActionResult Search(string searchText)
        {
            var searchResult = MovieRepo.GetAll().Where(f => f.Title.Contains(searchText, StringComparison.InvariantCultureIgnoreCase)).ToList();
            return View(searchResult);
        }
        [Route("Movie/Filtered/{Id}")]
        public IActionResult Filtered(int Id)
        {
            FilteredViewModel viewModel = new FilteredViewModel();
            viewModel.CategoryName = CatRepo.Get(Id)?.Name;
            if (viewModel.CategoryName == null)
            {
                return NotFound();
            }
            viewModel.Filtered = MovieRepo.GetAll().Where(f => f.Categories.Any(f => f.CategoryId == Id)).ToList();
            return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
