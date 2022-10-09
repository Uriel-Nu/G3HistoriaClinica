using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriaClinicaBD.Data.Entidades
{
    [Index(nameof(IdProfesional), Name = "DniProfesional-uq", IsUnique = true)]
    public class Profesional : EntytyBase
    {
        [Required(ErrorMessage = "Campo obligatorio")]
        
        public int IdProfesional { get; set; }

               

            [Required(ErrorMessage = "Campo obligatorio")]
            [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
            public string NombreCompleto { get; set; }

            [Required(ErrorMessage = "Campo obligatorio")]
            [MaxLength(8, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
            public string DNI { get; set; }
        
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string apellido { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string telefono { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string matricula { get; set; }   

        public List<HistoriaClinica> HistoriasClinicas { get; set; }
            public List<PACIENTE> Pacientes { get; set; }

    }
}
