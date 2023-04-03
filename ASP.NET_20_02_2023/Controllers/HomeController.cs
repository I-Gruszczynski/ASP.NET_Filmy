using ASP.NET_20_02_2023.DAL;
using ASP.NET_20_02_2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_20_02_2023.Controllers
{
    public class HomeController : Controller
    {
        FilmyContext db;

        public HomeController(FilmyContext db)
        {
            this.db = db;
        }
        
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
          //  _logger = logger;
        //}
        
        public IActionResult Index()
        {
            var kategoria = db.Kategorie.ToList();
            return View(kategoria);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult StronyStatyczne(string nazwa)
        {
            return View(nazwa);
        }


    }
}
