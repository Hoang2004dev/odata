using AutoMapper;
using OdataAssignment.Application.DTOs.Death;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Application.Interfaces.Services;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Application.Services;

public class DeathService : IDeathService
{
    private readonly IDeathRepository _repo;
    private readonly IMapper _mapper;

    public DeathService(IDeathRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public async Task<IEnumerable<DeathResponseDto>> GetAllAsync()
        => _mapper.Map<IEnumerable<DeathResponseDto>>(await _repo.GetAllAsync());

    public async Task<IEnumerable<DeathResponseDto>> GetByFilterAsync(DeathRequestDto request)
    {
        if (request.LocationId.HasValue)
            return _mapper.Map<IEnumerable<DeathResponseDto>>(await _repo.GetByLocationAsync(request.LocationId.Value));

        if (request.StartDate.HasValue && request.EndDate.HasValue)
            return _mapper.Map<IEnumerable<DeathResponseDto>>(await _repo.GetByDateRangeAsync(request.StartDate.Value, request.EndDate.Value));

        return await GetAllAsync();
    }

    public async Task<DeathResponseDto?> GetByIdAsync(long id)
        => _mapper.Map<DeathResponseDto>(await _repo.GetByIdAsync(id));
}
