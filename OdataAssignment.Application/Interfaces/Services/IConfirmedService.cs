using OdataAssignment.Application.DTOs.Confirmed;

namespace OdataAssignment.Application.Interfaces.Services;

public interface IConfirmedService
{
    IQueryable<ConfirmedResponseDto> Query();
    Task<ConfirmedResponseDto?> GetByIdAsync(long id);
}
