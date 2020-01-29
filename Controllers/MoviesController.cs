﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context=new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

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
            //var movies = _context.Movies.Include(m => m.Genre).ToList();

            //return View(movies);
            return View();
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            { 
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Details(int id)
        {
            var movie= _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()   
                };
                return View("MovieForm", viewModel);
            }
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberInStock = movie.NumberInStock;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            
            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel(movie)
            { 
                Genres = _context.Genres.ToList()
            };
            return View("MovieForm", viewModel);
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