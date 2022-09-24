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
        private readonly Conbd inydbcont;

        public PacientesController(Conbd Inydbcont)
        {
            inydbcont = Inydbcont;
        }
        [HttpGet]
        public async Task<ActionResult<List<PACIENTE>>> get()
        {
            return await inydbcont.Pacientes.ToListAsync();


        }
        [HttpGet("{ID:int}")]
        public async Task<ActionResult<PACIENTE>> get(int ID)
        {

            var paciente = await inydbcont.Pacientes.Where(p => p.ID == ID).FirstOrDefaultAsync();
            if (paciente == null)
            {
                return NotFound($"No existe la especialidad de ID={ID}");
            }
            return paciente;

            //[HttpGet("PacientePorNombre/{nombre}")]
            //public async Task<ActionResult<PACIENTE>> get(string nombre)
            //var paciente = await inydbcont.Pacientes.Where(p => p.nombre == nombre).FirstOrDefaultAsync();
            //if (paciente == null)
            //{
            //   return NotFound($"No existe la especialidad de ID={ID}");
        }
        //return paciente;
        [HttpPost]  
        public async Task<ActionResult<PACIENTE>> post(PACIENTE paciente)
        {
            await inydbcont.Pacientes.AddAsync(paciente);
            return paciente;
        }
    }
}   