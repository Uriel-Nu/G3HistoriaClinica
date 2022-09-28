﻿using Microsoft.EntityFrameworkCore;
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

    [Index(nameof (ID), Name = "Numero_HistoriaClinica-uq", IsUnique = true)]


    public class HistoriaClinica: EntytyBase
    {

        
        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El Diagnostico_Medico, es obligatorio ")]
        public string Diagnostico_Medico { get; set; }


        //Relacion 
        public List<PACIENTE>PACIENTES  { get; set; }


    

        //1 paciente, muchas historias clinicas
        //Poner relacion
        //PacienteId
        //ProfesionalId


    }



}
