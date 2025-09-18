using AutoMapper;
using OdataAssignment.Application.DTOs.DailyReport;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Application.Interfaces.Services;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Application.Services;

public class DailyReportService : IDailyReportService
{
    private readonly IDailyReportRepository _repo;
    private readonly IMapper _mapper;

    public DailyReportService(IDailyReportRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public async Task<IEnumerable<DailyReportResponseDto>> GetAllAsync()
        => _mapper.Map<IEnumerable<DailyReportResponseDto>>(await _repo.GetAllAsync());

    public async Task<IEnumerable<DailyReportResponseDto>> GetByFilterAsync(DailyReportRequestDto request)
    {
        if (request.LocationId.HasValue)
            return _mapper.Map<IEnumerable<DailyReportResponseDto>>(await _repo.GetByLocationAsync(request.LocationId.Value));

        if (request.ReportDate.HasValue)
            return _mapper.Map<IEnumerable<DailyReportResponseDto>>(await _repo.GetByDateAsync(request.ReportDate.Value));

        return await GetAllAsync();
    }

    public async Task<DailyReportResponseDto?> GetByIdAsync(long id)
        => _mapper.Map<DailyReportResponseDto>(await _repo.GetByIdAsync(id));
}
