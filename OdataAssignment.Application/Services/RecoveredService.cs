using AutoMapper;
using AutoMapper.QueryableExtensions;
using OdataAssignment.Application.DTOs.Recovered;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Application.Interfaces.Services;

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

    public IQueryable<RecoveredResponseDto> Query()
        => _repo.Query().ProjectTo<RecoveredResponseDto>(_mapper.ConfigurationProvider);

    public async Task<RecoveredResponseDto?> GetByIdAsync(long id)
        => _mapper.Map<RecoveredResponseDto>(await _repo.GetByIdAsync(id));
}
