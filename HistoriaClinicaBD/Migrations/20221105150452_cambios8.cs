using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoriaClinicaBD.Migrations
{
    public partial class cambios8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoriasClinicas_Pacientes_PacienteID",
                table: "HistoriasClinicas");

            migrationBuilder.DropIndex(
                name: "IX_HistoriasClinicas_PacienteID",
                table: "HistoriasClinicas");

            migrationBuilder.DropColumn(
                name: "PacienteID",
                table: "HistoriasClinicas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PacienteID",
                table: "HistoriasClinicas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HistoriasClinicas_PacienteID",
                table: "HistoriasClinicas",
                column: "PacienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoriasClinicas_Pacientes_PacienteID",
                table: "HistoriasClinicas",
                column: "PacienteID",
                principalTable: "Pacientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
