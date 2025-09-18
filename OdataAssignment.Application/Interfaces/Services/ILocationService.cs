using OdataAssignment.Application.DTOs.Confirmed;
using OdataAssignment.Application.DTOs.Location;

namespace OdataAssignment.Application.Interfaces.Services;

public interface ILocationService
{
    IQueryable<LocationResponseDto> Query();
    Task<LocationResponseDto?> GetByIdAsync(int id);
}
