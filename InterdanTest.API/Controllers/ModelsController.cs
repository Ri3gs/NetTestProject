using InterdanTest.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace InterdanTest.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModelsController : ControllerBase
    {
        public ModelsController()
        {
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<GetModelsResponse>> Get([FromQuery] GetModelsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
