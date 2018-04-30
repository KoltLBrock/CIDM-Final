using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BuffteksWebsite.Models;

namespace BuffteksWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //to do
            //determine way to assign members and clients ("ProjectParticipant"s) to the project
            //as well as a way to search and filter by those assignments
            //design a good bootstrap 4 layout and views




            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
