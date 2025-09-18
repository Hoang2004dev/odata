using AutoMapper;
using AutoMapper.QueryableExtensions;
using OdataAssignment.Application.DTOs.Location;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Application.Interfaces.Services;

namespace OdataAssignment.Application.Services;

public class LocationService : ILocationService
{
    private readonly ILocationRepository _repo;
    private readonly IMapper _mapper;

    public LocationService(ILocationRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public IQueryable<LocationResponseDto> Query()
        => _repo.Query().ProjectTo<LocationResponseDto>(_mapper.ConfigurationProvider);

    public async Task<LocationResponseDto?> GetByIdAsync(int id)
        => _mapper.Map<LocationResponseDto>(await _repo.GetByIdAsync(id));
}
