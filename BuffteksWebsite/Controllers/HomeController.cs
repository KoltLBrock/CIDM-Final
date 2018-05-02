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
            //to do:
            //determine way to assign members and clients ("ProjectParticipant"s) to the project
            //as well as a way to search and filter by those assignments
            //design a good bootstrap 4 layout and views

            // Only 1 client on a project
            // Student can only be on 1 project
            // edit particpant drop down should not include people who are already in a project, including the one being modified
            // no need to be able to edit new clients into projects
            // only need clients when adding new projects


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
