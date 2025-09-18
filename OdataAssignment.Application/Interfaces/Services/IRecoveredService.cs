using OdataAssignment.Application.DTOs.Recovered;

namespace OdataAssignment.Application.Interfaces.Services;

public interface IRecoveredService
{
    Task<IEnumerable<RecoveredResponseDto>> GetAllAsync();
    Task<IEnumerable<RecoveredResponseDto>> GetByFilterAsync(RecoveredRequestDto request);
    Task<RecoveredResponseDto?> GetByIdAsync(long id);
}
