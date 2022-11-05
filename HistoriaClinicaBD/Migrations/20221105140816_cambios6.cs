using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoriaClinicaBD.Migrations
{
    public partial class cambios6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Profesionales_ProfesionalID",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "DniProfesional-uq",
                table: "Profesionales");

            migrationBuilder.DropColumn(
                name: "IdProfesional",
                table: "Profesionales");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Profesionales",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProfesionalID",
                table: "Pacientes",
                newName: "ProfesionalId");

            migrationBuilder.RenameIndex(
                name: "IX_Pacientes_ProfesionalID",
                table: "Pacientes",
                newName: "IX_Pacientes_ProfesionalId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "HistoriasClinicas",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "NombreCompleto",
                table: "Profesionales",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Profesionales_ProfesionalId",
                table: "Pacientes",
                column: "ProfesionalId",
                principalTable: "Profesionales",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Profesionales_ProfesionalId",
                table: "Pacientes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Profesionales",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ProfesionalId",
                table: "Pacientes",
                newName: "ProfesionalID");

            migrationBuilder.RenameIndex(
                name: "IX_Pacientes_ProfesionalId",
                table: "Pacientes",
                newName: "IX_Pacientes_ProfesionalID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HistoriasClinicas",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "NombreCompleto",
                table: "Profesionales",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<int>(
                name: "IdProfesional",
                table: "Profesionales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "DniProfesional-uq",
                table: "Profesionales",
                column: "IdProfesional",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Profesionales_ProfesionalID",
                table: "Pacientes",
                column: "ProfesionalID",
                principalTable: "Profesionales",
                principalColumn: "ID");
        }
    }
}
