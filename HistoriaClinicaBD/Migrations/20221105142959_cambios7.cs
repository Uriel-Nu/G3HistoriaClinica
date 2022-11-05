using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoriaClinicaBD.Migrations
{
    public partial class cambios7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Profesionales_ProfesionalId",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_ProfesionalId",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "ProfesionalId",
                table: "Pacientes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfesionalId",
                table: "Pacientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_ProfesionalId",
                table: "Pacientes",
                column: "ProfesionalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Profesionales_ProfesionalId",
                table: "Pacientes",
                column: "ProfesionalId",
                principalTable: "Profesionales",
                principalColumn: "Id");
        }
    }
}
