using OdataAssignment.Application.DTOs.Death;

namespace OdataAssignment.Application.Interfaces.Services;

public interface IDeathService
{
    Task<IEnumerable<DeathResponseDto>> GetAllAsync();
    Task<IEnumerable<DeathResponseDto>> GetByFilterAsync(DeathRequestDto request);
    Task<DeathResponseDto?> GetByIdAsync(long id);
}