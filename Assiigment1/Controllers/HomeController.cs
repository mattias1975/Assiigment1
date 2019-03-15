using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebbAppFirstCore.Models;

namespace Assiigment1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sledge()
        {
            return View();
        }

        public IActionResult Kontakt()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Fever()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Fcheck(int temperatur)
        {
            ViewBag.DoctorSays = Temperature.FeverChecker(temperatur);
            return View();
        }
    }
}
