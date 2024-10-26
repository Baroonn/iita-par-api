using AutoMapper;
using PAR.Infrastructure.Models;
using PAR.Shared.DTOs;

namespace iita_par_api.Profiles
{
    public class StatusProfile : Profile
    {
        public StatusProfile() 
        {
            CreateMap<WorkplanStatusLogCreateDTO, Workplanstatuslog>();
            CreateMap<Workplanstatuslog, WorkplanStatusLogReadDTO>();
        }
    }
}
