using AutoMapper;
using OdataAssignment.Application.DTOs.Confirmed;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Application.Interfaces.Services;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Application.Services;

public class ConfirmedService : IConfirmedService
{
    private readonly IConfirmedRepository _repo;
    private readonly IMapper _mapper;

    public ConfirmedService(IConfirmedRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ConfirmedResponseDto>> GetAllAsync()
        => _mapper.Map<IEnumerable<ConfirmedResponseDto>>(await _repo.GetAllAsync());

    public async Task<IEnumerable<ConfirmedResponseDto>> GetByFilterAsync(ConfirmedRequestDto request)
    {
        if (request.LocationId.HasValue)
            return _mapper.Map<IEnumerable<ConfirmedResponseDto>>(await _repo.GetByLocationAsync(request.LocationId.Value));

        if (request.StartDate.HasValue && request.EndDate.HasValue)
            return _mapper.Map<IEnumerable<ConfirmedResponseDto>>(await _repo.GetByDateRangeAsync(request.StartDate.Value, request.EndDate.Value));

        return await GetAllAsync();
    }

    public async Task<ConfirmedResponseDto?> GetByIdAsync(long id)
        => _mapper.Map<ConfirmedResponseDto>(await _repo.GetByIdAsync(id));
}
