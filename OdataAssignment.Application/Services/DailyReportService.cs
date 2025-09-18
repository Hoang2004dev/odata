using AutoMapper;
using AutoMapper.QueryableExtensions;
using OdataAssignment.Application.DTOs.DailyReport;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Application.Interfaces.Services;

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

    public IQueryable<DailyReportResponseDto> Query()
        => _repo.Query().ProjectTo<DailyReportResponseDto>(_mapper.ConfigurationProvider);

    public async Task<DailyReportResponseDto?> GetByIdAsync(long id)
        => _mapper.Map<DailyReportResponseDto>(await _repo.GetByIdAsync(id));
}
