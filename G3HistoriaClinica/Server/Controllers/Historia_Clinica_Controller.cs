using HistoriaClinicaBD.Data;
using HistoriaClinicaBD.Data.Entidades;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace G3HistoriaClinica.Server.Controllers
{

    [ApiController]
    [Route("Api/Historia_Clinica")]


    public class Historia_Clinica_Controller: ControllerBase
    {

        private readonly Conbd Conbd;


        public Historia_Clinica_Controller(Conbd Conbd)
        { 

            this.Conbd = Conbd;

        }



        [HttpGet]//Trae todas las historias clinicas

        public async Task<ActionResult<List<Historia_Clinica>>>Get()
        {

            return await Conbd.HistoriasClinicas.ToListAsync();

        }



        [HttpGet("{ ID: int}")]//Trae las historias clinicas por ID

        public async Task<ActionResult<List<Historia_Clinica>>> Get(int ID)
        {

            var historia_clinica = await Conbd.HistoriasClinicas.Where(h => h.id == ID).Include(i => i.Historias_Clinicas)FirstOrDeafaultAsync();


            if(historia_clinica == null)
            { 

                return NotFound($" No existe la historia clinica con el id = {ID}");

            }


            return historia_clinica;

        }



        [HttpPost]
        public async Task<ActionResult<int>>Post(Historia_Clinica historia_Clinica)
        { 

            try
            { 

                //Graba en la base de datos
                Conbd.HistoriasClinicas.Add(historia_Clinica);
                await Conbd.SaveChangesAsync();
                return historia_Clinica.ID;


            }
            catch(Exception e)
            {

                return BadRequest(e.Message);

            }


        }



    }


}
