using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Calculator.Models;
using Microsoft.AspNetCore.Http;


namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.lastr = HttpContext.Session.GetString("result");
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

        public IActionResult Create()
        {
            ViewBag.result = HttpContext.Session.GetString("result");
          
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm] Calcilation calc)
        {
            Calculator2 calculator = new Calculator2();
            HttpContext.Session.SetString("result", (calculator.Caculation(calc).ToString()));
            ViewBag.result = HttpContext.Session.GetString("result");
            return View();
        }



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
