using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_MP_Madalina.Migrations
{
    public partial class Migrare11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Sceneta_varsta",
                table: "Sceneta",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(decimal),
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<int>(
                name: "Sceneta_pret",
                table: "Sceneta",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Sceneta_varsta",
                table: "Sceneta",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Sceneta_pret",
                table: "Sceneta",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 3);
        }
    }
}
