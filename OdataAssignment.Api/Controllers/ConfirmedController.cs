using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using OdataAssignment.Application.DTOs.Confirmed;
using OdataAssignment.Application.Interfaces.Services;

namespace OdataAssignment.Api.Controllers;

public class ConfirmedController : ODataController
{
    private readonly IConfirmedService _service;

    public ConfirmedController(IConfirmedService service) => _service = service;

    [EnableQuery(PageSize = 100)]
    public IActionResult Get()
    {
        return Ok(_service.Query());
    }

    [EnableQuery]
    public async Task<IActionResult> Get(long key)
    {
        var result = await _service.GetByIdAsync(key);
        return result == null ? NotFound() : Ok(result);
    }
}
