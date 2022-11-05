using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoriaClinicaBD.Migrations
{
    public partial class cambios10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoriasClinicas_Profesionales_ProfesionalID",
                table: "HistoriasClinicas");

            migrationBuilder.DropIndex(
                name: "IX_HistoriasClinicas_ProfesionalID",
                table: "HistoriasClinicas");

            migrationBuilder.DropColumn(
                name: "ProfesionalID",
                table: "HistoriasClinicas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfesionalID",
                table: "HistoriasClinicas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HistoriasClinicas_ProfesionalID",
                table: "HistoriasClinicas",
                column: "ProfesionalID");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoriasClinicas_Profesionales_ProfesionalID",
                table: "HistoriasClinicas",
                column: "ProfesionalID",
                principalTable: "Profesionales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
