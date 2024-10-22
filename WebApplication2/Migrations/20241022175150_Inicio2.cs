using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class Inicio2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Posicion",
                table: "Jugador",
                newName: "posicion");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Equipo",
                newName: "Nombre");

            migrationBuilder.AlterColumn<int>(
                name: "posicion",
                table: "Jugador",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "posicion",
                table: "Jugador",
                newName: "Posicion");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Equipo",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Posicion",
                table: "Jugador",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
