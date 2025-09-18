using AutoMapper;
using OdataAssignment.Application.DTOs.Location;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Application.Interfaces.Services;
using OdataAssignment.Domain.Entities;

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

    public async Task<IEnumerable<LocationResponseDto>> GetAllAsync()
        => _mapper.Map<IEnumerable<LocationResponseDto>>(await _repo.GetAllAsync());

    public async Task<LocationResponseDto?> GetByIdAsync(int id)
        => _mapper.Map<LocationResponseDto>(await _repo.GetByIdAsync(id));

    public async Task<IEnumerable<LocationResponseDto>> SearchAsync(LocationRequestDto request)
        => _mapper.Map<IEnumerable<LocationResponseDto>>(await _repo.SearchAsync(request.Keyword ?? string.Empty));
}
