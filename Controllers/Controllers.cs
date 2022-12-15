using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Software.Design.Services;

namespace Software.Design.Models.Controllers;

[ApiController]
[Route("api/F1_database")]
public class Controller : ControllerBase
{
    private readonly ILogger<Controller> _logger;
    private readonly My_Services _service;


    public Controller(
        ILogger<Controller> logger,
        My_Services service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<F1>>> Get()
    {
        var placeholder = await _service.Get();
        return Ok(placeholder);
    }

    [HttpPost]
    public async Task<ActionResult<List<F1>>> Create(F1DTO f1DTO)
    {
        var placeholder = await _service.Create(f1DTO);
        return Ok(placeholder);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<F1>> Get_By_ID(int id)
    {
        var placeholder = await _service.Get_By_ID(id);
        return Ok(placeholder);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<F1>> Edit_By_ID(int id, F1DTO f1DTO)
    {
        var placeholder = await _service.Edit(id, f1DTO);
        return Ok(placeholder);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<F1>> Delete_By_ID(int id)
    {
        var placeholder = await _service.Delete(id);
        return Ok(placeholder);
    }

    private ObjectResult Created(object value)
    {
        return StatusCode(201, value);
    }

    
}
