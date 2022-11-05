using HistoriaClinicaBD.Data.Entidades;
using HistoriaClinicaBD.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace G3HistoriaClinica.Server.Controllers
{
    [ApiController]
    [Route("Api/Profecional")]
    public class ProfesionalController : ControllerBase
    {
        //private readonly Conbd context;

        private readonly Conbd context;

        public ProfesionalController(Conbd context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Profesional>>> Get()
        {
            var profionales = await context.Profesionales.ToListAsync();
            return profionales;
        }
    }
}

//       // [HttpGet("{ID:int}")]
//       // public async Task<ActionResult<Profesional>>
//    }
//}

