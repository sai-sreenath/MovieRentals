using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using VideoRentals.Models;
using VideoRentals.ViewModels;

namespace VideoRentals.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer1"},
                new Customer {Name = "Customer2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

            //ViewData["Movie"] = movie;
            //ViewBag.RandomMovie = movie;
            //return View(movie);
            //return View(movie);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year + "/" + month);
        }

        public ActionResult Edit(int Id)
        {
            return Content("id=" + Id);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //if (!pageIndex.HasValue)
        //    pageIndex = 1;

        //if (string.IsNullOrWhiteSpace(sortBy))
        //    sortBy = "Name";

        //return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
        public ActionResult Index()
        { 
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id=1, Name="shrek"},
                new Movie{Id=2, Name = "Wall-e"}
            };
        }
    }

}