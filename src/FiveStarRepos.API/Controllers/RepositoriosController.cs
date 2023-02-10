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
    public class RepositoriosController : ControllerBase
    {
        /// <summary>
        /// Registra os repositórios
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Get([FromServices] ICriarRepositorioHandler service) 
        {
            var response = await service.Handler();

            if (!response.Sucesso)
                return BadRequest(response);

            return StatusCode(StatusCodes.Status201Created, response);
        }

        /// <summary>
        /// Recupera um repositório por id
        /// </summary>
        /// <param name="service"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRepositoryById([FromServices] IRecuperarRepositorioHandler service, long id)
        {
            var response = await service.Get(id);

            if (!response.Sucesso)
                return BadRequest(response);

            return Ok(response);
        }

        /// <summary>
        /// Busca paginada de repositorios
        /// </summary>
        /// <param name="service"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetRepository([FromServices] IListarRepositoriosHandler service, [FromQuery] ListarRepositoriosQuery request)
        {
            var response = await service.SearchAsync(request);

            return Ok(response);
        }
    }
}
