using FiveStarRepos.Application.Commands.Interfaces;
using FiveStarRepos.Application.Queries.Interfaces;
using FiveStarRepos.Application.Queries.ListarRepositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FiveStarRepos.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class GitHubApiController : ControllerBase
    {
        /// <summary>
        /// Registra os repositórios
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Get([FromServices] ICriarRepositorioHandler service) 
        {
            await service.Handler();

            return StatusCode(StatusCodes.Status201Created);
        }

        /// <summary>
        /// Lista um repositório por id
        /// </summary>
        /// <param name="service"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRepositoryById([FromServices] IRecuperarRepositorioHandler service, long id)
        {
            var response = await service.Get(id);

            if (response is null)
                return NoContent();

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetRepository([FromServices] IListarRepositoriosHandler service, [FromQuery] ListarRepositoriosQuery request)
        {
            var response = await service.SearchAsync(request);

            return Ok(response);
        }
    }
}
