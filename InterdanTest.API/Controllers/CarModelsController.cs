using InterdanTest.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InterdanTest.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarModelsController : ControllerBase
    {
        public CarModelsController()
        {
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<GetCarModelsResponse>> Get([FromQuery] GetCarModelsRequest request, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
