using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoriaClinicaBD.Migrations
{
    public partial class datosPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Pacientes",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Pacientes",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Pacientes",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DNI",
                table: "Pacientes",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Pacientes",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "telefono",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "DNI",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "telefono",
                table: "Pacientes");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Pacientes",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "nombre",
                table: "Pacientes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);
        }
    }
}
