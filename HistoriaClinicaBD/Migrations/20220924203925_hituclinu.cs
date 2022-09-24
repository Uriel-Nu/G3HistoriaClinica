using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoriaClinicaBD.Migrations
{
    public partial class hituclinu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoriasClinicas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Completo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Edad = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Estado_Civil = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Telefono_Fijo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Telefono_Celular = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Localidad = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Barrio = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Peso = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Talla = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Habitos_Alimenticios = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IMC = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nivel_Educativo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Antecedentes_Personales = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Antecedentes_Familiares = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Numeros_Habitaciones_Domicilio = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Numeros_Personas_Domicilio = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Estudios_Medicos_Realizados = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Diagnostico_Medico = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriasClinicas", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "Numero_HistoriaClinica-uq",
                table: "HistoriasClinicas",
                column: "ID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoriasClinicas");
        }
    }
}
