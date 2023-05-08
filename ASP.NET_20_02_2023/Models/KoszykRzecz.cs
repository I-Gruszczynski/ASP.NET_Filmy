using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_20_02_2023.Models
{
    public class KoszykRzecz
    {
        public Film Film { get; set; }
        public int Ilosc { get; set; }
        public decimal? Wartosc { get; set; }
    }
}
