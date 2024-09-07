using AutoMapper;
using PAR.Infrastructure.Models;
using PAR.Shared.DTOs;

namespace iita_par_api.Profiles
{
    public class KpiProfile : Profile
    {
        public KpiProfile() 
        {
            CreateMap<Irskpi, KpiReadDTO>();
            CreateMap<KpiCreateDTO, Irskpi>();
            CreateMap<KpiUpdateDTO, Irskpi>();
        }
    }
}
