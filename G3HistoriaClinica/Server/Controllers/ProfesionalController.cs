using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace G3HistoriaClinica.Server.Controllers
{
    [ApiController]
    [Route("Api/Profecional")]
    public class ProfesionalController : ControllerBase  
    {
        private ProfesionalController(Condb context)
        {
           
        }
    }
}
