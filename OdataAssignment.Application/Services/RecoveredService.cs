using AutoMapper;
using OdataAssignment.Application.DTOs.Recovered;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Application.Interfaces.Services;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Application.Services;

public class RecoveredService : IRecoveredService
{
    private readonly IRecoveredRepository _repo;
    private readonly IMapper _mapper;

    public RecoveredService(IRecoveredRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public async Task<IEnumerable<RecoveredResponseDto>> GetAllAsync()
        => _mapper.Map<IEnumerable<RecoveredResponseDto>>(await _repo.GetAllAsync());

    public async Task<IEnumerable<RecoveredResponseDto>> GetByFilterAsync(RecoveredRequestDto request)
    {
        if (request.LocationId.HasValue)
            return _mapper.Map<IEnumerable<RecoveredResponseDto>>(await _repo.GetByLocationAsync(request.LocationId.Value));

        if (request.StartDate.HasValue && request.EndDate.HasValue)
            return _mapper.Map<IEnumerable<RecoveredResponseDto>>(await _repo.GetByDateRangeAsync(request.StartDate.Value, request.EndDate.Value));

        return await GetAllAsync();
    }

    public async Task<RecoveredResponseDto?> GetByIdAsync(long id)
        => _mapper.Map<RecoveredResponseDto>(await _repo.GetByIdAsync(id));
}
