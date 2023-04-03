using ASP.NET_20_02_2023.DAL;
using ASP.NET_20_02_2023.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_20_02_2023.Controllers
{
    public class FilmyController : Controller
    {
        FilmyContext db;
        IWebHostEnvironment hostingEnvironment;
        public FilmyController(FilmyContext db, IWebHostEnvironment hostingEnvironment)
        {
            this.db = db;
            this.hostingEnvironment = hostingEnvironment;
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

        [HttpGet]
        public ActionResult DodajFilm()
        {
            DodawanieFilmowViewModel dodaj = new DodawanieFilmowViewModel();
            
            var kategoria = db.Kategorie.ToList();

            dodaj.kategoria = kategoria;
            
            return View(dodaj); 
        }

        [HttpPost]
        public ActionResult DodajFilm(DodawanieFilmowViewModel obj)
        { 
            obj.film.DataDodania = System.DateTime.Now;

            var plakatFolderPath = Path.Combine(hostingEnvironment.WebRootPath, "content");

            var unikatNazwaPlakatu = Guid.NewGuid()+"_"+obj.Plakat.FileName;

            var plakatPath = Path.Combine(plakatFolderPath, unikatNazwaPlakatu);

            obj.Plakat.CopyTo(new FileStream(plakatPath, FileMode.Create));

            obj.film.Plakat = unikatNazwaPlakatu;

            db.Filmy.Add(obj.film);

            db.SaveChanges();

            return RedirectToAction("Dodaj Film"); 
        }
    }
}
