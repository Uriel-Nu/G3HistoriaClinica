using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoriaClinicaBD.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profesionales",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProfesional = table.Column<int>(type: "int", nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DNI = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HistoriasClinicas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diagnostico_Medico = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProfesionalID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriasClinicas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HistoriasClinicas_Profesionales_ProfesionalID",
                        column: x => x.ProfesionalID,
                        principalTable: "Profesionales",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    edad = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    telefono = table.Column<int>(type: "int", nullable: false),
                    EstadoCivil = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    hijos = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ProfesionalID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pacientes_Profesionales_ProfesionalID",
                        column: x => x.ProfesionalID,
                        principalTable: "Profesionales",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoriasClinicas_ProfesionalID",
                table: "HistoriasClinicas",
                column: "ProfesionalID");

            migrationBuilder.CreateIndex(
                name: "Dnipaciente-uq",
                table: "Pacientes",
                column: "DNI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_ProfesionalID",
                table: "Pacientes",
                column: "ProfesionalID");

            migrationBuilder.CreateIndex(
                name: "DniProfesional-uq",
                table: "Profesionales",
                column: "IdProfesional",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoriasClinicas");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Profesionales");
        }
    }
}
