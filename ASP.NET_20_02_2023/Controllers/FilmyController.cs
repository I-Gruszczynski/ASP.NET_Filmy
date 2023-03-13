using ASP.NET_20_02_2023.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_20_02_2023.Controllers
{
    public class FilmyController : Controller
    {
        FilmyContext db;
        public FilmyController(FilmyContext db)
        {
            this.db = db;
        }

        public IActionResult Lista(string nazwaKategorii)
        {
            var kategoria = db.Kategorie.Include("Filmy").Where(k => k.Nazwa.ToUpper() == nazwaKategorii).Single();

            var filmy = kategoria.Filmy.ToList();


            //ViewBag.nazwa;
            return View(filmy);
        }
    }
}
