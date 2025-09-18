using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using OdataAssignment.Application.Interfaces.Services;

namespace OdataAssignment.Api.Controllers;

public class LocationsController : ODataController
{
    private readonly ILocationService _service;

    public LocationsController(ILocationService service) => _service = service;

    [EnableQuery(PageSize = 100)]
    public IActionResult Get()
        => Ok(_service.Query());

    [EnableQuery]
    public async Task<IActionResult> Get(int key)
    {
        var result = await _service.GetByIdAsync(key);
        return result == null ? NotFound() : Ok(result);
    }
}
