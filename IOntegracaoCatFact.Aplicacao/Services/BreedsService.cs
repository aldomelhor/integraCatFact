using AutoMapper;
using IntegraCatFactApi.Aplicacao.DTOs;
using IntegraCatFactApi.Aplicacao.Interfaces;

namespace IntegraCatfactApi.Aplicacao.Services
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

        public async Task<ResponseGenerico<BreedsDtos>> BuscarBreeds(int? limite)
        {
            var retorno = await _catfactApi.BuscarBreeds(limite);

            //return _mapper.Map<BreedsResponse>(retorno.DadosRetorno);

            return _mapper.Map<ResponseGenerico<BreedsDtos>>(retorno);
        }
    }
}
