using AutoMapper;
using AutoMapper.QueryableExtensions;
using OdataAssignment.Application.DTOs.Confirmed;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Application.Interfaces.Services;

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

    public IQueryable<ConfirmedResponseDto> Query()
        => _repo.Query().ProjectTo<ConfirmedResponseDto>(_mapper.ConfigurationProvider);

    public async Task<ConfirmedResponseDto?> GetByIdAsync(long id)
    {
        var entity = await _repo.GetByIdAsync(id);
        return _mapper.Map<ConfirmedResponseDto>(entity);
    }
}
