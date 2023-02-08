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
        public async Task<IActionResult> Get([FromServices] IGitHubNetwork service) 
        {
            TopFiveReposRequest req = new()
            {
                Query = "language:csharp",
                CampoOrdenacao = "stars",
                TipoOrdenacao = "desc",
                Pagina = 1,
                Quantidade = 5
            };

            var response = await service.Get(req);

            if (!response.IsSuccessStatusCode)
                return NoContent();

            return Ok(response.Content);

        }
    }
}
