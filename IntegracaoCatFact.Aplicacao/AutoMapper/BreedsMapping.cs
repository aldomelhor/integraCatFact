using AutoMapper;
using IntegraCatFact.Aplicacao.DTOs;
using IntegraCatFact.Dominio.Models;

namespace IntegraCatfact.Aplicacao.AutoMapper
{
    public class BreedsMapping : Profile
    {
        public BreedsMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            
            CreateMap<BreedsDto, BreedsModel>();
            CreateMap<DataDto, DataModelo>();

            CreateMap<BreedsModel, BreedsDto>();
            CreateMap<DataModelo, DataDto>();
        }
    }
}
