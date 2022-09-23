using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoriaClinicaBD.Migrations
{
    public partial class modhc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EstadoCivil",
                table: "Pacientes",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "edad",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "hijos",
                table: "Pacientes",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AmpliacionesHc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", maxLength: 8, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmpliacionesHc", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "Dnipaciente-uq",
                table: "Pacientes",
                column: "DNI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DNIPaciente-uq",
                table: "AmpliacionesHc",
                column: "DNI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DNIProfesional-uq",
                table: "AmpliacionesHc",
                column: "DNI",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmpliacionesHc");

            migrationBuilder.DropIndex(
                name: "Dnipaciente-uq",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "edad",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "hijos",
                table: "Pacientes");
        }
    }
}
