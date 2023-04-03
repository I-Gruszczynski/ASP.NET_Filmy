using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_20_02_2023.Migrations
{
    public partial class migracjaDlugoscFilmu2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 9,
                column: "DlugoscFilmu",
                value: 160);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 10,
                column: "DlugoscFilmu",
                value: 170);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 9,
                column: "DlugoscFilmu",
                value: null);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 10,
                column: "DlugoscFilmu",
                value: null);
        }
    }
}
