using AutoMapper;
using PAR.Infrastructure.Models;
using PAR.Shared.DTOs;

namespace iita_par_api.Profiles
{
    public class ObjectiveProfile : Profile
    {
        public ObjectiveProfile() 
        { 
            CreateMap<Irsworkplan, ObjectiveReadDTO>();
            CreateMap<ObjectiveCreateDTO, Irsworkplan>();
            CreateMap<ObjectiveUpdateDTO, Irsworkplan>();
        }
    }
}
