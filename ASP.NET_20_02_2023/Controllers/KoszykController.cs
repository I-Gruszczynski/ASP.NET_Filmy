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

        public KoszykController(FilmyContext dbs)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<KoszykRzecz>>(HttpContext.Session, Consts.KoszykSessionKey);

            ViewBag.CenaCalkowita = cart.Sum(item => item.Ilosc * item.Film.Cena);
            
            return View(cart);
        }

        public IActionResult DodajDoKoszyka(int id)
        {
            var film = db.Filmy.Find(id);
            if (SessionHelper.GetObjectFromJson<List<KoszykRzecz>>(HttpContext.Session, Consts.KoszykSessionKey)==null)
            {
                List<KoszykRzecz> cart = new List<KoszykRzecz>();

                cart.Add(new KoszykRzecz { Film = film, Ilosc = 1, Wartosc = film.Cena});
            }
            else
            {
                List<KoszykRzecz> cart= SessionHelper.GetObjectFromJson<List<KoszykRzecz>>(HttpContext.Session, Consts.KoszykSessionKey);

                int index = PobierzIndeks(id);

                if (index != -1)
                {
                    cart[index].Ilosc++;
                }
                else
                {
                    cart.Add(new KoszykRzecz { Film = film, Ilosc = 1, Wartosc = film.Cena});
                }

                SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.KoszykSessionKey, cart);
            }

            return RedirectToAction("Index");
        }
        [Route("Dodaj/{id}")]

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
    }
}
