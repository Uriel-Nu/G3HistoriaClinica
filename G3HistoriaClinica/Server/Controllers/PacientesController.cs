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
        private readonly Conbd DbContext;


        public PacientesController(Conbd DbContext)
        {
            this.DbContext = DbContext;
        }
        //[HttpGet]
        [HttpGet]
        public async Task<ActionResult<List<PACIENTE>>> Get()
        {
            var paciente = await DbContext.Pacientes.ToListAsync();
            return paciente;
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(PACIENTE pacientei)
        {
            try
            {
                PACIENTE paciente = new PACIENTE();
                paciente.ID = pacientei.ID;
                pacientei.Apellido = pacientei.Apellido;
                pacientei.DNI = pacientei.DNI;
                pacientei.edad = pacientei.edad;
                pacientei.Direccion = pacientei.Direccion;
                pacientei.telefono = pacientei.telefono;
                pacientei.EstadoCivil = pacientei.EstadoCivil;
                pacientei.hijos = pacientei.hijos;


                DbContext.Pacientes.Add(pacientei);
                await DbContext.SaveChangesAsync();
                return pacientei.ID;
            }
            catch (Exception error)
            {
                return BadRequest(error.GetBaseException + error.Message);
            }

            //        [HttpPost]

            //        async Task<ActionResult<int>> Post(PACIENTE pacientei)
            //        {
            //            try
            //            {
            //                DbContext.pacientes.(pacientei);
            //                await DbContext.SaveChangesAsync();
            //                return pacientei.ID;
            //            }
            //            catch (Exception e)
            //            {
            //                return BadRequest(e.Message);
            //            }
            //        }
            //    }
            //}





        }
    }
}

        

  

        
    



       