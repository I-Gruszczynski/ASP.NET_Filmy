﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_20_02_2023.Models
{
    public class KategoriaViewModels
    {
        public Kategoria Kategoria {get; set;}
        public IEnumerable<Film> FilmyKategoria { get; set; }

        public IEnumerable<Film> FilmyNajnowsze { get; set; }

    }
}
