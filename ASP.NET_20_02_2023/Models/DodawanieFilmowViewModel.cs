using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace ASP.NET_20_02_2023.Models
{
    public class DodawanieFilmowViewModel
    {
        public Film film { get; set; }
        public IFormFile Plakat { get; set; }
        public List<Kategoria> kategoria { get; set; }
    }
}
