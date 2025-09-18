using OdataAssignment.Application.DTOs.Location;

namespace OdataAssignment.Application.Interfaces.Services;

public interface ILocationService
{
    Task<IEnumerable<LocationResponseDto>> GetAllAsync();
    Task<LocationResponseDto?> GetByIdAsync(int id);
    Task<IEnumerable<LocationResponseDto>> SearchAsync(LocationRequestDto request);
}
