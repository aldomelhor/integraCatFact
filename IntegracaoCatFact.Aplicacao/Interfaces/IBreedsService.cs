using IntegraCatFact.Aplicacao.DTOs;

namespace IntegraCatFact.Aplicacao.Interfaces
{
    public interface IBreedsService
    {
        Task<ResponseGenerico<BreedsDto>> BuscarBreeds(int? limite, string? raca, string? pais, string? origem, string? casaco, string? padrao);
    }
}
