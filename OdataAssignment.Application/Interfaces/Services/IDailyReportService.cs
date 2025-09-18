using OdataAssignment.Application.DTOs.DailyReport;

namespace OdataAssignment.Application.Interfaces.Services;

public interface IDailyReportService
{
    IQueryable<DailyReportResponseDto> Query();
    Task<DailyReportResponseDto?> GetByIdAsync(long id);
}
