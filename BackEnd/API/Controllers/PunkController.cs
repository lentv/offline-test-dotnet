using ApiClient;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PunkController : ControllerBase
    {
        private readonly IPunkApiClient _devToApiClient;

        public PunkController(IPunkApiClient devToApiClient)
        {
            _devToApiClient = devToApiClient;
        }

        [HttpGet("beers")]
        public async Task<ActionResult> GetBeers()
        {            
            return new OkObjectResult(await _devToApiClient.GetBeers());
        }
    }
}
