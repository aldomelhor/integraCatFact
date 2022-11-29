using AutoMapper;
using IntegraCatFact.Aplicacao.DTOs;
using IntegraCatFact.Aplicacao.Interfaces;

namespace IntegraCatfact.Aplicacao.Services
{
    public class BreedsService : IBreedsService
    {
        private readonly IMapper _mapper;
        private readonly ICatfactApi _catfactApi;

        public BreedsService(IMapper mapper, ICatfactApi catfactApi)
        {
            _mapper = mapper;
            _catfactApi = catfactApi;
        }

        public async Task<ResponseGenerico<BreedsDto>> BuscarBreeds(int? limite, string? raca, string? pais, string? origem, string? casaco, string? padrao)
        {
            var retorno = await _catfactApi.BuscarBreeds(limite);

            if (retorno.DadosRetorno.dados != null && (!String.IsNullOrEmpty(raca) || !String.IsNullOrEmpty(pais) || !String.IsNullOrEmpty(origem) || !String.IsNullOrEmpty(casaco) || !String.IsNullOrEmpty(padrao)))
            {
                var aplicarFiltros = retorno.DadosRetorno.dados.Where(x => x.Raca == raca || x.Pais == pais || x.Origem == origem || x.Casaco == casaco || x.Padrao == padrao).ToList();

                retorno.DadosRetorno.dados = aplicarFiltros;
            }

            return _mapper.Map<ResponseGenerico<BreedsDto>>(retorno);
        }
    }
}
