using AutoMapper;
using PAR.Infrastructure.Models;
using PAR.Shared.DTOs;
using System.Text;

namespace iita_par_api.Profiles
{
    public class ActivityProfile : Profile
    {
        public ActivityProfile() 
        {
            CreateMap<ActivityCreateDTO, Irsactivity>()
                .ForMember(dest => dest.AdditionalSuggestions, opt => opt.MapFrom(src => src.AdditionalSuggestions != null ? Encoding.UTF8.GetBytes(src.AdditionalSuggestions) : null))
                .ForMember(dest => dest.NextYearGoals, opt => opt.MapFrom(src => src.NextYearGoals != null ? Encoding.UTF8.GetBytes(src.NextYearGoals) : null))
                .ForMember(dest => dest.ResponsibilityChanges, opt => opt.MapFrom(src => src.ResponsibilityChanges != null ? Encoding.UTF8.GetBytes(src.ResponsibilityChanges) : null))
                .ForMember(dest => dest.ResponsibilityOutputs, opt => opt.MapFrom(src => src.ResponsibilityOutputs != null ? Encoding.UTF8.GetBytes(src.ResponsibilityOutputs) : null))
                .ForMember(dest => dest.SuccessAndChallenges, opt => opt.MapFrom(src => src.SuccessAndChallenges != null ? Encoding.UTF8.GetBytes(src.SuccessAndChallenges) : null))
                ;

            CreateMap<Irsactivity, ActivityReadDTO>()
                .ForMember(dest => dest.AdditionalSuggestions, opt => opt.MapFrom(src => src.AdditionalSuggestions != null ? Encoding.UTF8.GetString(src.AdditionalSuggestions) : null))
                .ForMember(dest => dest.NextYearGoals, opt => opt.MapFrom(src => src.NextYearGoals != null ? Encoding.UTF8.GetString(src.NextYearGoals) : null))
                .ForMember(dest => dest.ResponsibilityChanges, opt => opt.MapFrom(src => src.ResponsibilityChanges != null ? Encoding.UTF8.GetString(src.ResponsibilityChanges) : null))
                .ForMember(dest => dest.ResponsibilityOutputs, opt => opt.MapFrom(src => src.ResponsibilityOutputs != null ? Encoding.UTF8.GetString(src.ResponsibilityOutputs) : null))
                .ForMember(dest => dest.SuccessAndChallenges, opt => opt.MapFrom(src => src.SuccessAndChallenges != null ? Encoding.UTF8.GetString(src.SuccessAndChallenges) : null))
                ;

        }
    }
}
