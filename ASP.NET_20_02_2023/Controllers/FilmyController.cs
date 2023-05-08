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

            if (obj.film.Cena == null)
            {
                obj.film.Cena = 0.00m;
    }

            if (TryValidateModel(obj.film, "Film") && ModelState.IsValid)
            {


                var plakatFolderPath = Path.Combine(hostingEnvironment.WebRootPath, "content");

                var unikatNazwaPlakatu = Guid.NewGuid() + "_" + obj.Plakat.FileName;

                var plakatPath = Path.Combine(plakatFolderPath, unikatNazwaPlakatu);

                obj.Plakat.CopyTo(new FileStream(plakatPath, FileMode.Create));

                obj.film.Plakat = unikatNazwaPlakatu;

                db.Filmy.Add(obj.film);

                db.SaveChanges();
                TempData["Dodaj"] = "Dodao Film!";

                return RedirectToAction("Dodaj Film");
}
            return View(obj);
        }
        [HttpPost]
        public IActionResult Szukaj(string tekst)
        {

            if (!String.IsNullOrEmpty(tekst))
            {
                var filmy = db.Filmy.Where(f => f.Tytul.Contains(tekst));

                ViewBag.Fraza = tekst;

                filmy.ToList();

                return View(filmy);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult EdytujFilm(int filmId)
        {
            var film = db.Filmy.Where(f => f.Id == filmId).FirstOrDefault();

            return View(film);
        }

        [HttpPost]
        public IActionResult EdytujFilm(Film filmEdited)
        {
            var film = db.Filmy.Where(f => f.Id == filmEdited.Id).FirstOrDefault();

            film.Tytul = filmEdited.Tytul;
            film.Rezyser = filmEdited.Rezyser;
            film.Opis = filmEdited.Opis;

            film.DataDodania = DateTime.Now;

            db.Entry(film).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Szczegoly", new { id = film.Id});
        }
            
        }
    }

