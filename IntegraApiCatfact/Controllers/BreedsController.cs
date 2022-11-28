using IntegraCatFactApi.Aplicacao.Interfaces;
using IntegraCatFactApi.Dominio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegraCatFactApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreedsController : ControllerBase
    {
        public readonly IBreedsService _breedsService;

        public BreedsController(IBreedsService breedsService)
        {
            _breedsService = breedsService;
        }

        [HttpGet()]
        [Route("buscar/{limite:int}")]
        public async Task<ActionResult> BuscarBreeds(int? limite, BreedsModel? filtros)
        {
            var response = await _breedsService.BuscarBreeds(limite);

            //return Ok(response);

            if (response.CodigoHttp == HttpStatusCode.OK)
                return Ok(response.DadosRetorno);
            else
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }
}
