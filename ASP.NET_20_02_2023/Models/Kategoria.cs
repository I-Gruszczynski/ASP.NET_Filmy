using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_20_02_2023.Models
{
    public class Kategoria
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Opis { get; set; }

        public ICollection<Film> Filmy { get; set; }
    }
}
