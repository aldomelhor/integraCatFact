using AutoMapper;
using IntegraCatFactApi.Aplicacao.DTOs;
using IntegraCatFactApi.Dominio.Models;

namespace IntegraCatfactApi.Aplicacao.AutoMapper
{
    public class BreedsMapping : Profile
    {
        public BreedsMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BreedsDtos, BreedsModel>();
            CreateMap<BreedsModel, BreedsDtos>();
        }
    }
}
