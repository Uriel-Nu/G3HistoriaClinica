using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HistoriaClinicaBD.Data.Entidades
{
    [Index(nameof(DNI), Name = "Dnipaciente-uq", IsUnique = true)]

    public class PACIENTE : EntytyBase
    {
        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El nombre,no puede superar los {1} caracteres  ")]

        public string nombre{ get; set; }

        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El nombre, no puede superar los {1} caracteres ")]

        public string Apellido { get; set; }

        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El nombre, no puede superar los {1} caracteres ")]
        public string DNI { get; set; }

        [Required(ErrorMessage = " Campo obligatorio")]
        public int edad { get; set; }

        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El nombre, no puede superar los {1} caracteres ")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = " Campo obligatorio")]
        
        public int telefono { get; set; }

        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El nombre, no puede superar los {1} caracteres ")]

        public string EstadoCivil { get; set; }

        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(2, ErrorMessage = " El nombre, no puede superar los {1} caracteres ")]

        public string hijos { get; set; }


    }
}
