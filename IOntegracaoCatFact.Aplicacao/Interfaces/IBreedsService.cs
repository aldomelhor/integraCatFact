using IntegraCatFactApi.Aplicacao.DTOs;

namespace IntegraCatFactApi.Aplicacao.Interfaces
{
    public interface IBreedsService
    {
        Task<ResponseGenerico<BreedsDtos>> BuscarBreeds(int? limite);
    }
}
