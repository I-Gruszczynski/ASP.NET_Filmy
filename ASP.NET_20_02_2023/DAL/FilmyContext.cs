using ASP.NET_20_02_2023.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_20_02_2023.DAL
{
    public class FilmyContext:DbContext
    {
        public DbSet<Film> Filmy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public FilmyContext(DbContextOptions<FilmyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().HasData(

                new Film()
                {
                    Id=1,
                    KategoriaId=1,
                    Tytul="Osada",
                    Opis= "Kiedy Lucius łamie zakaz i wchodzi do lasu, gdzie żyją zwierzęta-bestie, te przystępują do ataku na osadę.",
                    Cena=10,
                    Rezyser= "M. Night Shyamalan",
                    DataDodania = new DateTime(2004,2,13)
                },
                new Film()
                {
                    Id = 2,
                    KategoriaId = 1,
                    Tytul = "Usmiechnij sie",
                    Opis = "Po tym, jak dr Rose Carter bierze udział w traumatycznym zdarzeniu z udziałem pacjentki, wokół niej zaczynają dziać się niewytłumaczalne rzeczy.",
                    Cena = 30,
                    Rezyser = "Parker Finn",
                    DataDodania = new DateTime(2022, 7, 24)
                },
                new Film()
                {
                    Id = 3,
                    KategoriaId = 2,
                    Tytul = "Zoolander",
                    Opis = "Derek zostaje zapomniany przez świat show biznesu. Kiedy kontrowersyjny projektant składa byłemu modelowi propozycję promowania najnowszej kolekcji, mężczyzna zgadza się bez namysłu.",
                    Cena = 30,
                    Rezyser = "Ben Stiller",
                    DataDodania = new DateTime(2001, 2, 03)
                },
                new Film()
                {
                    Id = 4,
                    KategoriaId = 2,
                    Tytul = "Głupi i głupszy",
                    Opis = "Dwóch przyjaciół przemierza drogi i miasta Ameryki, by oddać zgubioną przez atrakcyjną kobietę walizkę.",
                    Cena = 10,
                    Rezyser = "Bobby Farrelly, Peter Farrelly",
                    DataDodania = new DateTime(1994, 4, 30)
                },
                new Film()
                {
                    Id = 5,
                    KategoriaId = 3,
                    Tytul = "Gladiator",
                    Opis = "Generał Maximus - prawa ręka cesarza, szczęśliwy mąż i ojciec - w jednej chwili traci wszystko. Jako niewolnik-gladiator musi walczyć na arenie o przeżycie.",
                    Cena = 20,
                    Rezyser = "Ridley Scott",
                    DataDodania = new DateTime(2000, 1, 18)
                },
                new Film()
                {
                    Id = 6,
                    KategoriaId = 3,
                    Tytul = "Wojna imperiów",
                    Opis = "Sprzymierzone siły chińskiej armii i legendarnego zaginionego rzymskiego legionu bronią granicy przed generałem, który pragnie przejąć kontrolę nad Jedwabnym Szlakiem.",
                    Cena = 20,
                    Rezyser = "Daniel Lee",
                    DataDodania = new DateTime(2015, 3, 26)
                }, new Film()
                {
                    Id = 7,
                    KategoriaId = 4,
                    Tytul = "Szeregowiec Ryan",
                    Opis = "W poszukiwaniu zaginionego szeregowca wysłany zostaje doborowy oddział żołnierzy.",
                    Cena = 15,
                    Rezyser = "Steven Spielberg",
                    DataDodania = new DateTime(1998, 11, 06)
                },
                new Film()
                {
                    Id = 8,
                    KategoriaId = 4,
                    Tytul = "Bękarty wojny",
                    Opis = "W okupowanej przez nazistów Francji oddział złożony z Amerykanów żydowskiego pochodzenia planuje zamach na Hitlera.",
                    Cena = 10,
                    Rezyser = "Quentin Tarantino, Eli Roth",
                    DataDodania = new DateTime(2009, 1, 20)
                }, new Film()
                {
                    Id = 9,
                    KategoriaId = 5,
                    Tytul = "Kot w Butach",
                    Opis = "Kot w Butach wraz z kompanami organizuje skok, mający na celu znalezienie i porwanie mitycznej gęsi znoszącej złote jaja.",
                    Cena = 35,
                    Rezyser = "Chris Miller",
                    DataDodania = new DateTime(2011, 8, 02)
                }, new Film()
                {
                    Id = 10,
                    KategoriaId = 5,
                    Tytul = "Shrek",
                    Opis = "By odzyskać swój dom, brzydki ogr z gadatliwym osłem wyruszają uwolnić piękną księżniczkę.",
                    Cena = 25,
                    Rezyser = "Andrew Adamson, Vicky Jenson",
                    DataDodania = new DateTime(2001, 4, 19)
                }

                );
        }
    }
}
