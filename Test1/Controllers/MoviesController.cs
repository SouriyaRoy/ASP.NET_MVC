using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class MoviesController : Controller
    {
        static List<Movie> allmovies = new List<Movie>()
        {
            new Movie()
            {
                ID = 1,
                Title = "Star Wars",
                ReleaseDate = DateTime.Now,
                Genre = "Action",
                Price = 100
            },
            new Movie()
            {
                ID = 2,
                Title = "Jaws",
                ReleaseDate = DateTime.Now,
                Genre = "Action",
                Price = 100
            },
            new Movie()
            {
                ID = 3,
                Title = "Predator",
                ReleaseDate = DateTime.Now,
                Genre = "Action",
                Price = 100
            },
            new Movie()
            {
                ID = 4,
                Title = "Mandalorian",
                ReleaseDate = DateTime.Now,
                Genre = "Action",
                Price = 100
            },
            new Movie()
            {
                ID = 5,
                Title = "Matrix",
                ReleaseDate = DateTime.Now,
                Genre = "SciFi",
                Price = 100
            }
        };
        public ActionResult All()
        {
            return View(allmovies);
        }

        public ActionResult Details(int id)
        {
            var movie = allmovies.Find(m => m.ID == id);
            return View(movie);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var movie = allmovies.Find(m => m.ID == id);
            return View(movie);
        }
        [HttpPost]
        public ActionResult Edit(Movie newMovie)
        {
            var oldMovieId = newMovie.ID;
            var oldMovie = allmovies.Find(m => m.ID == oldMovieId);
            allmovies.Remove(oldMovie);
            allmovies.Add(newMovie);
            return RedirectToAction("All");
        }

        //public ActionResult Delete()
        //{

        //}

        [HttpGet]
        public ActionResult Create()
        {
            Movie m = new Movie();
            return View(m);
        }
        [HttpPost]
        public ActionResult Create(Movie m) //model binding
        {
            if (ModelState.IsValid)
                allmovies.Add(m);
            return View(m);
        }
        // GET: Movies
        public ActionResult Index()
        {
            return View(allmovies);
        }
    }
}