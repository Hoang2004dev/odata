using AutoMapper;
using AutoMapper.QueryableExtensions;
using OdataAssignment.Application.DTOs.Death;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Application.Interfaces.Services;

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

    public IQueryable<DeathResponseDto> Query()
        => _repo.Query().ProjectTo<DeathResponseDto>(_mapper.ConfigurationProvider);

    public async Task<DeathResponseDto?> GetByIdAsync(long id)
        => _mapper.Map<DeathResponseDto>(await _repo.GetByIdAsync(id));
}
