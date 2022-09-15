using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriaClinicaBD.Data
{
    public class Bdcontex : DbContext
    {
        public Bdcontex(DbContextOptions options) : base(options)
        {
        }
    }
}
