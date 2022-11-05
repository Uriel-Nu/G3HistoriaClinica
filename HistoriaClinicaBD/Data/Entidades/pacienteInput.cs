using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriaClinicaBD.Data.Entidades
{
    internal class pacienteInput
    {
        public int ID { get; set; }

        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El nombre,no puede superar los {1} caracteres  ")]

        public string nombre { get; set; }

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
