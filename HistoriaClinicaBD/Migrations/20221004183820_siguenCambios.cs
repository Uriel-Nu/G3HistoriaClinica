using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoriaClinicaBD.Migrations
{
    public partial class siguenCambios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoriasClinicas_Profesionales_ProfesionalID",
                table: "HistoriasClinicas");

            migrationBuilder.AlterColumn<int>(
                name: "ProfesionalID",
                table: "HistoriasClinicas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_HistoriasClinicas_Profesionales_ProfesionalID",
                table: "HistoriasClinicas",
                column: "ProfesionalID",
                principalTable: "Profesionales",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoriasClinicas_Pacientes_PacienteID",
                table: "HistoriasClinicas");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoriasClinicas_Profesionales_ProfesionalID",
                table: "HistoriasClinicas");

            migrationBuilder.DropIndex(
                name: "IX_HistoriasClinicas_PacienteID",
                table: "HistoriasClinicas");

            migrationBuilder.DropColumn(
                name: "PacienteID",
                table: "HistoriasClinicas");

            migrationBuilder.AlterColumn<int>(
                name: "ProfesionalID",
                table: "HistoriasClinicas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoriasClinicas_Profesionales_ProfesionalID",
                table: "HistoriasClinicas",
                column: "ProfesionalID",
                principalTable: "Profesionales",
                principalColumn: "ID");
        }
    }
}
