using OdataAssignment.Application.DTOs.Confirmed;

namespace OdataAssignment.Application.Interfaces.Services;

public interface IConfirmedService
{
    Task<IEnumerable<ConfirmedResponseDto>> GetAllAsync();
    Task<IEnumerable<ConfirmedResponseDto>> GetByFilterAsync(ConfirmedRequestDto request);
    Task<ConfirmedResponseDto?> GetByIdAsync(long id);
}
