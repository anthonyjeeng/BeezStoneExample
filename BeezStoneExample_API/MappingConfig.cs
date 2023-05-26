
using AutoMapper;
using BeezStoneExample_API.Modelos;
using BeezStoneExample_API.Modelos.Dto;

namespace BeezStoneExample_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDto>();
            CreateMap<VillaDto, Villa>();

            CreateMap<Villa, VillaCreateDto>().ReverseMap(); //otra manera para hacer lo de arriba
            CreateMap<Villa, VillaUpdateDto>().ReverseMap();
        }
    }
}
