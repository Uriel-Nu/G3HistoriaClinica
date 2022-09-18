using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriaClinicaBD.Data.Entidades
{
    public class PACIENTE : EntytyBase
    {
        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El nombre, es obligatorio ")]

        public string nombre{ get; set; }

        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El nombre, es obligatorio ")]

        public string Apellido { get; set; }

        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El nombre, es obligatorio ")]
        public string DNI { get; set; }

        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El nombre, es obligatorio ")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = " Campo obligatorio")]
        
        public int telefono { get; set; }
    }
}
