using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Atomic.TestAeC.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cidade = table.Column<string>(type: "varchar(255)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualziadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoricAirportClimate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoIcao = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PressaoAtmosferica = table.Column<string>(type: "varchar(50)", nullable: false),
                    Visibilidade = table.Column<string>(type: "varchar(50)", nullable: false),
                    Vento = table.Column<int>(type: "int", nullable: false),
                    DirecaoVento = table.Column<int>(type: "int", nullable: false),
                    Umidade = table.Column<int>(type: "int", nullable: false),
                    Condicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CondicaoDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoClimaAeroporto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CityClimate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CidadeId = table.Column<int>(type: "int", nullable: false),
                    Condicao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Min = table.Column<int>(type: "int", nullable: false),
                    Max = table.Column<int>(type: "int", nullable: false),
                    IndiceUv = table.Column<int>(type: "int", nullable: false),
                    CondicaoDesc = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityClimate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CityClimate_City_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CityClimate_CidadeId",
                table: "CityClimate",
                column: "CidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityClimate");

            migrationBuilder.DropTable(
                name: "HistoricAirportClimate");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
