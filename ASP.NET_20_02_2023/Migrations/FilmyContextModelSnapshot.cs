﻿// <auto-generated />
using System;
using ASP.NET_20_02_2023.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP.NET_20_02_2023.Migrations
{
    [DbContext(typeof(FilmyContext))]
    partial class FilmyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP.NET_20_02_2023.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Cena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DataDodania")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DlugoscFilmu")
                        .HasColumnType("int");

                    b.Property<int>("KategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Rezyser")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriaId");

                    b.ToTable("Filmy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cena = 10m,
                            DataDodania = new DateTime(2004, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DlugoscFilmu = 90,
                            KategoriaId = 1,
                            Opis = "Kiedy Lucius łamie zakaz i wchodzi do lasu, gdzie żyją zwierzęta-bestie, te przystępują do ataku na osadę.",
                            Rezyser = "M. Night Shyamalan",
                            Tytul = "Osada"
                        },
                        new
                        {
                            Id = 2,
                            Cena = 30m,
                            DataDodania = new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DlugoscFilmu = 90,
                            KategoriaId = 1,
                            Opis = "Po tym, jak dr Rose Carter bierze udział w traumatycznym zdarzeniu z udziałem pacjentki, wokół niej zaczynają dziać się niewytłumaczalne rzeczy.",
                            Rezyser = "Parker Finn",
                            Tytul = "Usmiechnij sie"
                        },
                        new
                        {
                            Id = 3,
                            Cena = 30m,
                            DataDodania = new DateTime(2001, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DlugoscFilmu = 100,
                            KategoriaId = 2,
                            Opis = "Derek zostaje zapomniany przez świat show biznesu. Kiedy kontrowersyjny projektant składa byłemu modelowi propozycję promowania najnowszej kolekcji, mężczyzna zgadza się bez namysłu.",
                            Rezyser = "Ben Stiller",
                            Tytul = "Zoolander"
                        },
                        new
                        {
                            Id = 4,
                            Cena = 10m,
                            DataDodania = new DateTime(1994, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DlugoscFilmu = 110,
                            KategoriaId = 2,
                            Opis = "Dwóch przyjaciół przemierza drogi i miasta Ameryki, by oddać zgubioną przez atrakcyjną kobietę walizkę.",
                            Rezyser = "Bobby Farrelly, Peter Farrelly",
                            Tytul = "Głupi i głupszy"
                        },
                        new
                        {
                            Id = 5,
                            Cena = 20m,
                            DataDodania = new DateTime(2000, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DlugoscFilmu = 120,
                            KategoriaId = 3,
                            Opis = "Generał Maximus - prawa ręka cesarza, szczęśliwy mąż i ojciec - w jednej chwili traci wszystko. Jako niewolnik-gladiator musi walczyć na arenie o przeżycie.",
                            Rezyser = "Ridley Scott",
                            Tytul = "Gladiator"
                        },
                        new
                        {
                            Id = 6,
                            Cena = 20m,
                            DataDodania = new DateTime(2015, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DlugoscFilmu = 130,
                            KategoriaId = 3,
                            Opis = "Sprzymierzone siły chińskiej armii i legendarnego zaginionego rzymskiego legionu bronią granicy przed generałem, który pragnie przejąć kontrolę nad Jedwabnym Szlakiem.",
                            Rezyser = "Daniel Lee",
                            Tytul = "Wojna imperiów"
                        },
                        new
                        {
                            Id = 7,
                            Cena = 15m,
                            DataDodania = new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DlugoscFilmu = 140,
                            KategoriaId = 4,
                            Opis = "W poszukiwaniu zaginionego szeregowca wysłany zostaje doborowy oddział żołnierzy.",
                            Rezyser = "Steven Spielberg",
                            Tytul = "Szeregowiec Ryan"
                        },
                        new
                        {
                            Id = 8,
                            Cena = 10m,
                            DataDodania = new DateTime(2009, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DlugoscFilmu = 150,
                            KategoriaId = 4,
                            Opis = "W okupowanej przez nazistów Francji oddział złożony z Amerykanów żydowskiego pochodzenia planuje zamach na Hitlera.",
                            Rezyser = "Quentin Tarantino, Eli Roth",
                            Tytul = "Bękarty wojny"
                        },
                        new
                        {
                            Id = 9,
                            Cena = 35m,
                            DataDodania = new DateTime(2011, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DlugoscFilmu = 160,
                            KategoriaId = 5,
                            Opis = "Kot w Butach wraz z kompanami organizuje skok, mający na celu znalezienie i porwanie mitycznej gęsi znoszącej złote jaja.",
                            Rezyser = "Chris Miller",
                            Tytul = "Kot w Butach"
                        },
                        new
                        {
                            Id = 10,
                            Cena = 25m,
                            DataDodania = new DateTime(2001, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DlugoscFilmu = 170,
                            KategoriaId = 5,
                            Opis = "By odzyskać swój dom, brzydki ogr z gadatliwym osłem wyruszają uwolnić piękną księżniczkę.",
                            Rezyser = "Andrew Adamson, Vicky Jenson",
                            Tytul = "Shrek"
                        });
                });

            modelBuilder.Entity("ASP.NET_20_02_2023.Models.Kategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategorie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nazwa = "Horror",
                            Opis = "To jest horror"
                        },
                        new
                        {
                            Id = 2,
                            Nazwa = "Komedia",
                            Opis = "To jest komedia"
                        },
                        new
                        {
                            Id = 3,
                            Nazwa = "Historyczny",
                            Opis = "To jest historyczny"
                        },
                        new
                        {
                            Id = 4,
                            Nazwa = "Wojenny",
                            Opis = "To jest wojenny"
                        },
                        new
                        {
                            Id = 5,
                            Nazwa = "Familijny",
                            Opis = "To jest familijny"
                        });
                });

            modelBuilder.Entity("ASP.NET_20_02_2023.Models.Film", b =>
                {
                    b.HasOne("ASP.NET_20_02_2023.Models.Kategoria", "Kategoria")
                        .WithMany("Filmy")
                        .HasForeignKey("KategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategoria");
                });

            modelBuilder.Entity("ASP.NET_20_02_2023.Models.Kategoria", b =>
                {
                    b.Navigation("Filmy");
                });
#pragma warning restore 612, 618
        }
    }
}
