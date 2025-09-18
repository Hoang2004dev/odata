using OdataAssignment.Application.DTOs.DailyReport;

namespace OdataAssignment.Application.Interfaces.Services;

public interface IDailyReportService
{
    Task<IEnumerable<DailyReportResponseDto>> GetAllAsync();
    Task<IEnumerable<DailyReportResponseDto>> GetByFilterAsync(DailyReportRequestDto request);
    Task<DailyReportResponseDto?> GetByIdAsync(long id);
}