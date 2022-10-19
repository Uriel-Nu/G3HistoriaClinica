using HistoriaClinicaBD.Data;
using HistoriaClinicaBD.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace G3HistoriaClinica.Server.Controllers
{
    [ApiController]
    [Route("Api/Pacientes")]

    public class PacientesController : ControllerBase
    {
        private readonly Conbd context;
       

        public PacientesController(Conbd context)
        {
            this.context = context;
        }
        //[HttpGet]
        [HttpGet]
        public async Task<ActionResult<List<PACIENTE>>> Get()
        {
            var paciente = await context.Pacientes.ToListAsync();
            return paciente;
        }
        


        //}
        [HttpGet("{ID:int}")]
        public async Task<ActionResult<PACIENTE>> get(int ID)
        {

            var paciente = await context.Pacientes.Where(p => p.ID == ID).FirstOrDefaultAsync();
            if (paciente == null)
            {
                return NotFound($"No existe la especialidad de ID={ID}");
            }
            return paciente;

            
        }
        
        [HttpPost]
        
        public async Task<ActionResult<int>> Post(PACIENTE paciente)
        {
            try
            {
                context.Pacientes.Add(paciente);
                await context.SaveChangesAsync();
                return paciente.ID;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}   