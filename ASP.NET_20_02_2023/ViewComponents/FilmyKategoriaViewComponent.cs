using ASP.NET_20_02_2023.DAL;
using ASP.NET_20_02_2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_20_02_2023.ViewComponents
{
    public class FilmyKategoriaViewComponent:ViewComponent
    {
        FilmyContext db;

        public FilmyKategoriaViewComponent(FilmyContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(string nazwaKategorii)
        {
            var model = db.Kategorie.Include("Filmy").Where(k => k.Nazwa.ToUpper() == nazwaKategorii.ToUpper()).Single().Filmy.ToList();
            return await Task.FromResult((IViewComponentResult)View("_FilmyKategoria",model));
        }
    }
}
