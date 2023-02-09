using FiveStarRepos.Application.Commands.Interfaces;
using FiveStarRepos.Application.Queries.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FiveStarRepos.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class GitHubApiController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromServices] ICriarRepositorioHandler service) 
        {
            await service.Handler();

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRepository([FromServices] IRecuperarRepositorioQuery service, long id)
        {
            var response = await service.Get(id);

            if (response is null)
                return NoContent();

            return Ok(response);
        }
    }
}
