using AutoMapper;
using PAR.Infrastructure.Models;
using PAR.Shared.DTOs;

namespace iita_par_api.Profiles
{
    public class WorkplanProfile : Profile
    {
        public WorkplanProfile() 
        { 
            CreateMap<List<Irsworkplan>, WorkplanReadDTO>();
        }
    }
}
