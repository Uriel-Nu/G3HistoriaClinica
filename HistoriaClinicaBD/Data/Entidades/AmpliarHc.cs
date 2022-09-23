using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HistoriaClinicaBD.Data.Entidades
{
    [Index(nameof(DNI), Name = "DNIProfesional-uq", IsUnique = true)]
    [Index(nameof(DNI), Name = "DNIPaciente-uq", IsUnique = true)]

    public class AmpliarHc
    {
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(8, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string DNI { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(8, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public int ID { get; set; }




    }
}