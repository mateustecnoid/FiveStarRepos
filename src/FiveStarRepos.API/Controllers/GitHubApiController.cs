using FiveStarRepos.Infra.Dados.Network.Interfaces;
using FiveStarRepos.Infra.Data.Network.Interfaces;
using FiveStarRepos.Infra.Data.Network.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FiveStarRepos.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class GitHubApiController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromServices] IRepositorioNetwork service) 
        {
            

            var response = await service.GetRepository("csharp");

            if (response is null)
                return NoContent();

            return Ok(response);

        }
    }
}
