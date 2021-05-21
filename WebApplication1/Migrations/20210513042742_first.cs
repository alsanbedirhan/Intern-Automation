using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adays",
                columns: table => new
                {
                    AdayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdayAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdaySoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdayEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdayTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdayDogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdayAdres = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adays", x => x.AdayId);
                });

            migrationBuilder.CreateTable(
                name: "Basvurus",
                columns: table => new
                {
                    BasvuruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanID = table.Column<int>(type: "int", nullable: false),
                    AdayID = table.Column<int>(type: "int", nullable: false),
                    Puan = table.Column<int>(type: "int", nullable: false),
                    Durumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basvurus", x => x.BasvuruID);
                });

            migrationBuilder.CreateTable(
                name: "Deneyims",
                columns: table => new
                {
                    DeneyimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdayID = table.Column<int>(type: "int", nullable: false),
                    FirmaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pozisyon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deneyims", x => x.DeneyimID);
                });

            migrationBuilder.CreateTable(
                name: "Egitims",
                columns: table => new
                {
                    EgitimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdayID = table.Column<int>(type: "int", nullable: false),
                    EgitimDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OkulAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BolumAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egitims", x => x.EgitimID);
                });

            migrationBuilder.CreateTable(
                name: "Ilans",
                columns: table => new
                {
                    IlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IlanBaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IlanBitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IlanAktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilans", x => x.IlanID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adays");

            migrationBuilder.DropTable(
                name: "Basvurus");

            migrationBuilder.DropTable(
                name: "Deneyims");

            migrationBuilder.DropTable(
                name: "Egitims");

            migrationBuilder.DropTable(
                name: "Ilans");
        }
    }
}
