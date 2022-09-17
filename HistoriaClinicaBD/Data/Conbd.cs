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
        public DbSet<PACIENTE> Pacientes { get; set; }
        public Conbd(DbContextOptions options) : base(options)
        {
        }
    }
}

