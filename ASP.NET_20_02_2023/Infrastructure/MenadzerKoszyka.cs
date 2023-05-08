using ASP.NET_20_02_2023.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_20_02_2023.Infrastructure
{
    public class MenadzerKoszyka
    {
        public static int UsunZKoszyka(ISession session, int id)
        {
            var cart = WezRzeczy(session);

            var tenFilm = cart.Find(i => i.Film.Id == id);

            int ilosc = 0;

            if(tenFilm == null)
            {
                return ilosc;
            }
            if(tenFilm.Ilosc > 1)
            {
                tenFilm.Ilosc--;

                ilosc = tenFilm.Ilosc;
            }
            else
            {
                cart.Remove(tenFilm);
            }
            session.SetObjectAsJson(Consts.KoszykSessionKey, cart);
            return 0;
        }

        public static List<KoszykRzecz> WezRzeczy(ISession session)
        {
            var cart = SessionHelper.GetObjectFromJson<List<KoszykRzecz>>(session, Consts.KoszykSessionKey);

            if (cart == null)
            {
                cart = new List<KoszykRzecz>();
            }

            return cart;
        }

        public static decimal? UstawWartosc(ISession session)
        {
            var rzeczy = WezRzeczy(session);
            return rzeczy.Sum(rz => rz.Ilosc * rz.Wartosc);
        }
    }
}
