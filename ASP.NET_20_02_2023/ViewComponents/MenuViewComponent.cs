using ASP.NET_20_02_2023.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_20_02_2023.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        FilmyContext db;

        public MenuViewComponent(FilmyContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("_Menu", db.Kategorie.ToList()));
        }
    }
}
