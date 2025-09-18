using AutoMapper;
using OdataAssignment.Application.DTOs.Confirmed;
using OdataAssignment.Application.DTOs.DailyReport;
using OdataAssignment.Application.DTOs.Death;
using OdataAssignment.Application.DTOs.Location;
using OdataAssignment.Application.DTOs.Recovered;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Confirmed, ConfirmedResponseDto>()
            .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
            .ReverseMap();

        CreateMap<Death, DeathResponseDto>()
            .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
            .ReverseMap();

        CreateMap<Recovered, RecoveredResponseDto>()
            .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
            .ReverseMap();

        CreateMap<DailyReport, DailyReportResponseDto>()
            .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
            .ReverseMap();

        CreateMap<Location, LocationResponseDto>().ReverseMap();
    }
}
