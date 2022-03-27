using AutoMapper;
using defensoresCRUD.Core.Models.Dtos;
using DefensoresDeTablada.Core.Models;

namespace DefensoresDeTablada.Core.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Exercise, ExerciseDtoView>().ReverseMap();
        }
    }
}