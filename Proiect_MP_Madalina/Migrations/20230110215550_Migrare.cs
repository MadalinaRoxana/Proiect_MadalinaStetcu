using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_MP_Madalina.Migrations
{
    public partial class Migrare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Autor_Nume = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teatru",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Teatru_Denumire = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teatru", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sceneta",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sceneta_denumire = table.Column<string>(maxLength: 30, nullable: false),
                    Sceneta_categorie = table.Column<string>(maxLength: 100, nullable: false),
                    Sceneta_varsta = table.Column<decimal>(maxLength: 3, nullable: false),
                    AutorID = table.Column<int>(nullable: false),
                    TeatruID = table.Column<int>(nullable: false),
                    Sceneta_data = table.Column<DateTime>(nullable: false),
                    Sceneta_pret = table.Column<string>(maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sceneta", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sceneta_Autor_AutorID",
                        column: x => x.AutorID,
                        principalTable: "Autor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sceneta_Teatru_TeatruID",
                        column: x => x.TeatruID,
                        principalTable: "Teatru",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JoinScenetaWTeatru",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScenetaID = table.Column<int>(nullable: false),
                    TeatruID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinScenetaWTeatru", x => x.ID);
                    table.ForeignKey(
                        name: "FK_JoinScenetaWTeatru_Sceneta_ScenetaID",
                        column: x => x.ScenetaID,
                        principalTable: "Sceneta",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JoinScenetaWTeatru_Teatru_TeatruID",
                        column: x => x.TeatruID,
                        principalTable: "Teatru",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoinScenetaWTeatru_ScenetaID",
                table: "JoinScenetaWTeatru",
                column: "ScenetaID");

            migrationBuilder.CreateIndex(
                name: "IX_JoinScenetaWTeatru_TeatruID",
                table: "JoinScenetaWTeatru",
                column: "TeatruID");

            migrationBuilder.CreateIndex(
                name: "IX_Sceneta_AutorID",
                table: "Sceneta",
                column: "AutorID");

            migrationBuilder.CreateIndex(
                name: "IX_Sceneta_TeatruID",
                table: "Sceneta",
                column: "TeatruID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinScenetaWTeatru");

            migrationBuilder.DropTable(
                name: "Sceneta");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "Teatru");
        }
    }
}
