using ASP.NET_20_02_2023.DAL;
using ASP.NET_20_02_2023.Infrastructure;
using ASP.NET_20_02_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_20_02_2023.Controllers
{
    public class KoszykController : Controller
    {
        FilmyContext db;

        public KoszykController(FilmyContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<KoszykRzecz>>(HttpContext.Session, Consts.KoszykSessionKey);
            if (cart == null)
            {
                cart = new List<KoszykRzecz>();
            }
            ViewBag.CenaCalkowita = cart.Sum(item => item.Ilosc * item.Film.Cena);
            
            return View(cart);
        }

        [Route("Dodaj/{id}")]
        public IActionResult DodajDoKoszyka(int id)
        {
            var cart = SessionHelper.GetObjectFromJson<List<KoszykRzecz>>(HttpContext.Session, Consts.KoszykSessionKey);
            var film = db.Filmy.Find(id);
            if (cart == null)
            {
                cart = new List<KoszykRzecz>();

                cart.Add(new KoszykRzecz { Film = film, Ilosc = 1, Wartosc = film.Cena});
            }
            else
            {
                 cart= SessionHelper.GetObjectFromJson<List<KoszykRzecz>>(HttpContext.Session, Consts.KoszykSessionKey);

                int index = PobierzIndeks(id);

                if (index != -1)
                {
                    cart[index].Ilosc++;
                }
                else
                {
                    cart.Add(new KoszykRzecz { Film = film, Ilosc = 1, Wartosc = film.Cena});
                }

            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.KoszykSessionKey, cart);

            return RedirectToAction("Index");
        }
       

        private int PobierzIndeks(int id)
        {
            List<KoszykRzecz> cart = SessionHelper.GetObjectFromJson<List<KoszykRzecz>>(HttpContext.Session, Consts.KoszykSessionKey);

            for (int i = 0; i < cart.Count(); i++)
            {
                if (cart[i].Film.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

        public IActionResult UsunZKoszyka(int id)
        {
            var model = new UsunRzeczViewModel()
            {
                RzeczId = id,
                IloscRzeczy = MenadzerKoszyka.UsunZKoszyka(HttpContext.Session, id),
                WartoscKoszyka = MenadzerKoszyka.UstawWartosc(HttpContext.Session)

            };
            return Json(model);
        }
    }
}
