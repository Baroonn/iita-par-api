using AutoMapper;
using PAR.Infrastructure.Models;
using PAR.Shared.DTOs;
using PAR.Shared.Enums;
using System.Text;

namespace iita_par_api.Profiles
{
    public class AppraisalProfile : Profile
    {
        public AppraisalProfile() 
        {
            CreateMap<KeyValuePair<AppraisalScoreKey, float>, Appraisalscore>()
                .ForMember(dest => dest.ScoreKey, opt => opt.MapFrom(src => src.Key.ToString()))
                .ForMember(dest => dest.Score, opt => opt.MapFrom(src => src.Value));

            CreateMap<Appraisal, AppraisalReadDTO>()
                .ForMember(dest => dest.Appeal, opt => opt.MapFrom(src => src.Appeal == "true"))
                .ForMember(dest => dest.AppraiseeServed, opt => opt.MapFrom(src => src.Appraisalcommittees.Count > 0))
                .ForMember(dest => dest.Score, opt => opt.MapFrom(src => src.Appraisalscores.ToDictionary(
                    item => Enum.Parse<AppraisalScoreKey>(item.ScoreKey),
                    item => item.Score
                )));
            ;
            CreateMap<AppraisalEditDTO, Appraisal>()
                .ForMember(dest => dest.Appraisalscores, opt => opt.MapFrom(src => src.Score))
                .ForMember(dest => dest.Appeal, opt => opt.MapFrom(src => src.Appeal.ToString()));
        }
    }
}
