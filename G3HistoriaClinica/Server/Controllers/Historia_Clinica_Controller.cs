using HistoriaClinicaBD.Data;
using HistoriaClinicaBD.Data.Entidades;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace G3HistoriaClinica.Server.Controllers
{

    [ApiController]
    [Route("Api/Historia_Clinica")]


    public class Historia_Clinica_Controller : ControllerBase
    {

        private readonly Conbd Conbd;


        public Historia_Clinica_Controller(Conbd Conbd)
        {

            this.Conbd = Conbd;

        }



        [HttpGet]//Trae todas las historias clinicas

        public async Task<ActionResult<List<HistoriaClinica>>> Get()
        {
            List<HistoriaClinica> res;
            try
            {
                res = await Conbd.HistoriasClinicas.ToListAsync();
            }
            catch (Exception e)
            {

                throw;
            }

            return res;
        }
    }
}



       // [HttpGet("{ ID: int}")]//Trae las historias clinicas por ID

        //public async Task<ActionResult<List<HistoriaClinica>>> Get(int Id);

        //    [HttpGet("{ID:int}")]
        //public async Task<ActionResult<HistoriaClinica>> get(int Id)
        //{

        //    var HistoriaClinica = await Conbd.HistoriasClinicas.Where(p => p.Id == Id).FirstOrDefaultAsync();
        //    if (HistoriaClinica == null)
        //    {
        //        return NotFound($"No existe la especialidad de ID={Id}");
        //    }
        //    return HistoriaClinica;

        //    var historia_clinica = await Conbd.HistoriasClinicas.Where(h => h.Id == Id).Include(i => i.HistoriaClinicas).FirstOrDeafaultAsync();


        //    if (historia_clinica == null)
        //    {

        //        return NotFound($" No existe la historia clinica con el id = {Id}");

        //    }


        //    return historia_clinica;

        //} } }



//[HttpPost]
//public async Task<ActionResult<int>>Post(HistoriaClinica historia_Clinica)
// { 

//try
//{ 

//Graba en la base de datos
//Conbd.HistoriasClinicas.Add(historia_Clinica);
// await Conbd.SaveChangesAsync();
// return historia_Clinica.Id;


// }
//catch(Exception e)
//{

// return BadRequest(e.Message);

//}


//}



// }


//}
