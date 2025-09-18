using AutoMapper;
using OdataAssignment.Application.DTOs.Confirmed;
using OdataAssignment.Application.DTOs.DailyReport;
using OdataAssignment.Application.DTOs.Death;
using OdataAssignment.Application.DTOs.Location;
using OdataAssignment.Application.DTOs.Recovered;
using OdataAssignment.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OdataAssignment.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Confirmed
        CreateMap<Confirmed, ConfirmedResponseDto>().ReverseMap();

        // Death
        CreateMap<Death, DeathResponseDto>().ReverseMap();

        // Recovered
        CreateMap<Recovered, RecoveredResponseDto>().ReverseMap();

        // DailyReport
        CreateMap<DailyReport, DailyReportResponseDto>()
            .ForMember(dest => dest.CountryRegion,
                       opt => opt.MapFrom(src => src.Location.CountryRegion))
            .ForMember(dest => dest.ProvinceState,
                       opt => opt.MapFrom(src => src.Location.ProvinceState))
            .ForMember(dest => dest.DailyIncrease, opt => opt.Ignore());

        // Location
        CreateMap<Location, LocationResponseDto>().ReverseMap();
    }
}
