using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iita_par_api.Controllers
{
    [Route("api/workplans")]
    [ApiController]
    public class WorkplansController : ControllerBase
    {
        [HttpGet("{year:int:length(4)}")]
        public async Task<IActionResult> GetWorkplan(int year)
        {
            return Ok();
        }
    }
}
