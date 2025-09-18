using OdataAssignment.Application.DTOs.Confirmed;
using OdataAssignment.Application.DTOs.Recovered;

namespace OdataAssignment.Application.Interfaces.Services;

public interface IRecoveredService
{
    IQueryable<RecoveredResponseDto> Query();
    Task<RecoveredResponseDto?> GetByIdAsync(long id);
}
