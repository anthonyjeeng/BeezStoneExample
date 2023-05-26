using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeezStoneExample_API.Migrations
{
    /// <inheritdoc />
    public partial class RellenarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la villa...", new DateTime(2023, 5, 26, 10, 27, 39, 960, DateTimeKind.Local).AddTicks(7970), new DateTime(2023, 5, 26, 10, 27, 39, 960, DateTimeKind.Local).AddTicks(7958), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la villa...", new DateTime(2023, 5, 26, 10, 27, 39, 960, DateTimeKind.Local).AddTicks(7974), new DateTime(2023, 5, 26, 10, 27, 39, 960, DateTimeKind.Local).AddTicks(7973), "", 50, "Villa Real", 5, 200.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
