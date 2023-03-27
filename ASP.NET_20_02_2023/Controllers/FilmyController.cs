using ASP.NET_20_02_2023.DAL;
using ASP.NET_20_02_2023.Models;
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
            var kategoriaModel = new KategoriaViewModels();  
            kategoriaModel.Kategoria = db.Kategorie.Include("Filmy").Where(k => k.Nazwa.ToUpper() == nazwaKategorii).Single();

            kategoriaModel.FilmyKategoria = kategoriaModel.Kategoria.Filmy.ToList();

            kategoriaModel.FilmyNajnowsze = db.Filmy.OrderByDescending(k => k.DataDodania).Take(3);
            //ViewBag.nazwa;
            return View(kategoriaModel);
        }
        public IActionResult Szczegoly(int id)
        {
            var idFilm = db.Filmy.Include("Kategoria").Where(x => x.Id == id).Single();
            return View(idFilm);
        }
    }
}
