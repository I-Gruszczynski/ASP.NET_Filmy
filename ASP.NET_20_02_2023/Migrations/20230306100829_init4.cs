using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_20_02_2023.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tytul = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Rezyser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DataDodania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmy_Kategorie_KategoriaId",
                        column: x => x.KategoriaId,
                        principalTable: "Kategorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "Id", "Nazwa", "Opis" },
                values: new object[,]
                {
                    { 1, "Horror", "To jest horror" },
                    { 2, "Komedia", "To jest komedia" },
                    { 3, "Historyczny", "To jest historyczny" },
                    { 4, "Wojenny", "To jest wojenny" },
                    { 5, "Familijny", "To jest familijny" }
                });

            migrationBuilder.InsertData(
                table: "Filmy",
                columns: new[] { "Id", "Cena", "DataDodania", "KategoriaId", "Opis", "Rezyser", "Tytul" },
                values: new object[,]
                {
                    { 1, 10m, new DateTime(2004, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Kiedy Lucius łamie zakaz i wchodzi do lasu, gdzie żyją zwierzęta-bestie, te przystępują do ataku na osadę.", "M. Night Shyamalan", "Osada" },
                    { 2, 30m, new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Po tym, jak dr Rose Carter bierze udział w traumatycznym zdarzeniu z udziałem pacjentki, wokół niej zaczynają dziać się niewytłumaczalne rzeczy.", "Parker Finn", "Usmiechnij sie" },
                    { 3, 30m, new DateTime(2001, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Derek zostaje zapomniany przez świat show biznesu. Kiedy kontrowersyjny projektant składa byłemu modelowi propozycję promowania najnowszej kolekcji, mężczyzna zgadza się bez namysłu.", "Ben Stiller", "Zoolander" },
                    { 4, 10m, new DateTime(1994, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Dwóch przyjaciół przemierza drogi i miasta Ameryki, by oddać zgubioną przez atrakcyjną kobietę walizkę.", "Bobby Farrelly, Peter Farrelly", "Głupi i głupszy" },
                    { 5, 20m, new DateTime(2000, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Generał Maximus - prawa ręka cesarza, szczęśliwy mąż i ojciec - w jednej chwili traci wszystko. Jako niewolnik-gladiator musi walczyć na arenie o przeżycie.", "Ridley Scott", "Gladiator" },
                    { 6, 20m, new DateTime(2015, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Sprzymierzone siły chińskiej armii i legendarnego zaginionego rzymskiego legionu bronią granicy przed generałem, który pragnie przejąć kontrolę nad Jedwabnym Szlakiem.", "Daniel Lee", "Wojna imperiów" },
                    { 7, 15m, new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "W poszukiwaniu zaginionego szeregowca wysłany zostaje doborowy oddział żołnierzy.", "Steven Spielberg", "Szeregowiec Ryan" },
                    { 8, 10m, new DateTime(2009, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "W okupowanej przez nazistów Francji oddział złożony z Amerykanów żydowskiego pochodzenia planuje zamach na Hitlera.", "Quentin Tarantino, Eli Roth", "Bękarty wojny" },
                    { 9, 35m, new DateTime(2011, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Kot w Butach wraz z kompanami organizuje skok, mający na celu znalezienie i porwanie mitycznej gęsi znoszącej złote jaja.", "Chris Miller", "Kot w Butach" },
                    { 10, 25m, new DateTime(2001, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "By odzyskać swój dom, brzydki ogr z gadatliwym osłem wyruszają uwolnić piękną księżniczkę.", "Andrew Adamson, Vicky Jenson", "Shrek" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmy_KategoriaId",
                table: "Filmy",
                column: "KategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmy");

            migrationBuilder.DropTable(
                name: "Kategorie");
        }
    }
}
