using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proy_AdminVtasWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AgregaCamposInventarioSuc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "InventarioTda",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sucursal",
                table: "InventarioTda",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "InventarioTda");

            migrationBuilder.DropColumn(
                name: "Sucursal",
                table: "InventarioTda");
        }
    }
}
