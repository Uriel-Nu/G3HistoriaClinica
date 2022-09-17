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

        public int nombre{ get; set; }

        public int id { get; set; }

    }
}
