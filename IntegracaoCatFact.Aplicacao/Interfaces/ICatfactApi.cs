using IntegraCatFact.Aplicacao.DTOs;
using IntegraCatFact.Dominio.Models;

namespace IntegraCatFact.Aplicacao.Interfaces
{
    public interface ICatFactApi
    {
        Task<ResponseGenerico<BreedsModel>> BuscarBreeds(int? limite);
    }
}
