using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_core_dotnet_core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "About the OWASP DevSlop Tools Project.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contacting the DevSlop Team.";

            return View();
        }

        public IActionResult Team()
        {
            ViewData["Message"] = "The OWASP DevSlop Project Team Members.";

            return View();
        }


        public IActionResult Modules()
        {
            ViewData["Message"] = "OWASP DevSlop Project Modules.";

            return View();
        }

        public IActionResult Resources()
        {
            ViewData["Message"] = "Learning Resources";

            return View();
        }


        public IActionResult Schedule()
        {
            ViewData["Message"] = "Scheduled Appearances";

            return View();
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
