using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevSlop.Models;
using DevSlop.Slop.Repositories;

namespace DevSlop.Controllers
{
    public class HomeController : Controller
    {
        private IScheduleRepository _scheduleRepo;

        public HomeController(IScheduleRepository scheduleRepository)
        {
            _scheduleRepo = scheduleRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "About the OWASP DevSlop Tools Project";


            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contacting the DevSlop Team";

            return View();
        }

        public IActionResult Team()
        {
            ViewData["Message"] = "The OWASP DevSlop Project Team Members";

            return View();
        }


        public IActionResult Modules()
        {
            ViewData["Message"] = "OWASP DevSlop Project Modules";

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

            var scheduleList = _scheduleRepo.GetAllSchedules();
            return View(scheduleList);
        }

        public IActionResult Pixi()
        {
            ViewData["Message"] = "DevSlop Pixi Module";

            return View();
        }

        public IActionResult Pixi_CRS()
        {
            ViewData["Message"] = "DevSlop Pixi-CRS Module";

            return View();
        }

        public IActionResult Patty()
        {
            ViewData["Message"] = "DevSlop Patty Module";

            return View();
        }

        public IActionResult DevSecOps_Studio()
        {
            ViewData["Message"] = "DevSlop DevSecOps Studio Module";

            return View();
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
