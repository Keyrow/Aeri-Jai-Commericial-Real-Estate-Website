using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecipeWebsite.Models;
using Microsoft.AspNetCore.Identity;


namespace RecipeWebsite.Controllers
{
    public class HomeController : Controller
    {
        // Get Route for Home page
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        // Get Route for Properties
        [HttpGet]
        [Route("Properties")]
        public IActionResult Properties()
        {
            return View();
        }
        // Get Route for About
        [HttpGet]
        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
        // Get Route for FAQ
        [HttpGet]
        [Route("FAQ")]
        public IActionResult FAQ()
        {
            return View();
        }




        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
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
