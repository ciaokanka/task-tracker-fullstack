using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class TasksController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new[] { new { Id = 1, Title = "Sample Task" } });
}
