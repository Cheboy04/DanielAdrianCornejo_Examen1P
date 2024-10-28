using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DanielAdrianCornejo_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class DCInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DC_Tabla1",
                columns: table => new
                {
                    DC_CarroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DC_Cantidad = table.Column<int>(type: "int", nullable: false),
                    DC_Marca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DC_Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DC_Vendido = table.Column<bool>(type: "bit", nullable: false),
                    DC_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DC_Tabla1", x => x.DC_CarroID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DC_Tabla1");
        }
    }
}
