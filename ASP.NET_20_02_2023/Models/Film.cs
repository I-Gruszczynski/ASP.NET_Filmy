using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_20_02_2023.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Podaj tytul")]
        [StringLength(50)]
        public string Tytul { get; set; }

        [Required(ErrorMessage = "Podaj rezysera")]
        [StringLength(50)]
        public string Rezyser { get; set; }

        [Required(ErrorMessage = "Podaj opis")]
        [StringLength(200)]
        public string Opis { get; set; }
        public decimal? Cena { get; set; }
        public DateTime DataDodania { get; set; }

        [ForeignKey("Kategoria")]
        public int KategoriaId { get; set; }
        public Kategoria Kategoria { get; set; }
    }
}
