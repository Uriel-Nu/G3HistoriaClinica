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

    [Index(nameof (ID), Name = "Numero_HistoriaClinica-uq", IsUnique = true)]


    public class HistoriaClinica: EntityBase
    {

        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El Nombre_Completo, es obligatorio ")]
        public string Nombre_Completo { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El ID, es obligatorio ")]
        public int ID{ get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El DNI, es obligatorio ")]
        public string DNI { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El Edad, es obligatorio ")]
        public int Edad { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El Estado_Civil, es obligatorio ")]
        public string Estado_Civil { get; set; }

        
        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El Telefono_Fijo, es obligatorio ")]
        public string Telefono_Fijo { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El Telefono_Celular, es obligatorio ")]
        public string Telefono_Celular { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " La Localidad, es obligatorio ")]
        public string Localidad { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " La Provincia, es obligatorio ")]
        public string Provincia { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El Pais, es obligatorio ")]
        public string Pais { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El Barrio, es obligatorio ")]
        public string Barrio { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " La Direccion, es obligatorio ")]
        public string Direccion { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El Peso, es obligatorio ")]
        public string Peso { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " La Talla, es obligatorio ")]
        public string Talla { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " Los Habitos_Alimenticios, es obligatorio ")]
        public string Habitos_Alimenticios { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El IMC, es obligatorio ")]
        public string IMC { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El Nivel_Educativo, es obligatorio ")]
        public string Nivel_Educativo { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " Los Antecdentes_Personales, es obligatorio ")]
        public string Antecedentes_Personales { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " Los Antecedentes_Familiares, es obligatorio ")]
        public string Antecedentes_Familiares { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " Los Numeros_Habitaciones_Domicilio, es obligatorio ")]
        public string Numeros_Habitaciones_Domicilio { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " Los Numeros_Personas_Domicilio, es obligatorio ")]
        public string Numeros_Personas_Domicilio { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " Los Estudios_Medicos_Realizados, es obligatorio ")]
        public string Estudios_Medicos_Realizados { get; set; }


        [Required(ErrorMessage = " Campo obligatorio")]
        [MaxLength(10, ErrorMessage = " El Diagnostico_Medico, es obligatorio ")]
        public string Diagnostico_Medico { get; set; }



        public List<PACIENTE>PACIENTES  { get; set; }


    }



}
