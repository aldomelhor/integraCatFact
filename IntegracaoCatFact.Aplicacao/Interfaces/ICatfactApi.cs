using IntegraCatFact.Aplicacao.DTOs;
using IntegraCatFact.Dominio.Models;

namespace IntegraCatFact.Aplicacao.Interfaces
{
    public interface ICatfactApi
    {
        Task<ResponseGenerico<BreedsModel>> BuscarBreeds(int? limite);
    }
}
