using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_20_02_2023.Models
{
    public class DodawanieFilmowViewModel
    {
        public Film film { get; set; }
        [Required(ErrorMessage = "Dodak plakat")]
        public IFormFile Plakat { get; set; }
        public List<Kategoria> kategoria { get; set; }
    }
}
