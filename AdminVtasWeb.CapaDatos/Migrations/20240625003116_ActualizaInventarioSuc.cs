using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proy_AdminVtasWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class ActualizaInventarioSuc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdArticulo",
                table: "InventarioTda",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "CodigoArticulo",
                table: "InventarioTda",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoArticulo",
                table: "InventarioTda");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "InventarioTda",
                newName: "IdArticulo");
        }
    }
}
