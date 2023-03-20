using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_20_02_2023.Migrations
{
    public partial class migracjaDlugoscFilmu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DlugoscFilmu",
                table: "Filmy",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 1,
                column: "DlugoscFilmu",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 2,
                column: "DlugoscFilmu",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 3,
                column: "DlugoscFilmu",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 4,
                column: "DlugoscFilmu",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 5,
                column: "DlugoscFilmu",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 6,
                column: "DlugoscFilmu",
                value: 130);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 7,
                column: "DlugoscFilmu",
                value: 140);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 8,
                column: "DlugoscFilmu",
                value: 150);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DlugoscFilmu",
                table: "Filmy");
        }
    }
}
