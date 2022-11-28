using IntegraCatFactApi.Aplicacao.DTOs;
using IntegraCatFactApi.Dominio.Models;

namespace IntegraCatFactApi.Aplicacao.Interfaces
{
    public interface ICatfactApi
    {
        Task<ResponseGenerico<BreedsModel>> BuscarBreeds(int? limite);
    }
}
