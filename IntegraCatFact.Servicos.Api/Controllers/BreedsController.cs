using IntegraCatFact.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegraCatFact.Servicos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BreedsController : ControllerBase
    {
        public readonly IBreedsService _breedsService;

        public BreedsController(IBreedsService breedsService)
        {
            _breedsService = breedsService;
        }

        [HttpGet()]
        [Route("buscar")]
        public async Task<ActionResult> BuscarBreeds(int? limite, string? raca, string? pais, string? origem, string? casaco, string? padrao)
        {
            var response = await _breedsService.BuscarBreeds(limite, raca, pais, origem, casaco, padrao);

            if (response.CodigoHttp == HttpStatusCode.OK)
                return Ok(response.DadosRetorno);
            else
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }
}