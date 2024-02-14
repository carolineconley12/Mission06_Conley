using Microsoft.AspNetCore.Mvc;
using Mission06_Conley.Models;
using System.Diagnostics;

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
            return View();
        }

        [HttpPost]
        public IActionResult Form(Application response) 
        {
            _context.Applications.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }

    }

}     

