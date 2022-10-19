using HistoriaClinicaBD.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriaClinicaBD.Data
{

    public class Conbd : DbContext
    {
        public Conbd(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PACIENTE> Pacientes { get; set; }
        
        public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }

        public DbSet<Profesional> Profesionales { get; set; }

    }
}


