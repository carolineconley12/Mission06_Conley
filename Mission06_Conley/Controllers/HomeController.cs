// Caroline Conley Mission #7

using Microsoft.AspNetCore.Mvc;
using Mission06_Conley.Models;

using Microsoft.EntityFrameworkCore;

namespace Mission06_Conley.Controllers
{
    public class HomeController : Controller
    {
       private MovieContext _context;
       public HomeController(MovieContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Form(Movie response) 
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }

        [HttpGet]
        public IActionResult List()
        { // Go to table that shows the movie list
            var applications = _context.Movies
                .Include("Category") 
                .ToList();

            return View(applications);

        }

        [HttpGet]
            public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id );

            ViewBag.Categories = _context.Categories.ToList();

            return View("Form", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);

        }
        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("List");
        }
    }

}     

