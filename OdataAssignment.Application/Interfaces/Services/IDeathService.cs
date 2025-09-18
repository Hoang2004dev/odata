using OdataAssignment.Application.DTOs.Confirmed;
using OdataAssignment.Application.DTOs.DailyReport;
using OdataAssignment.Application.DTOs.Death;

namespace OdataAssignment.Application.Interfaces.Services;

public interface IDeathService
{
    IQueryable<DeathResponseDto> Query();
    Task<DeathResponseDto?> GetByIdAsync(long id);
}