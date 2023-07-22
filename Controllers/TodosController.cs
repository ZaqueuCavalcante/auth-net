using AuthNet.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AuthNet.Controllers;

[ApiController, Route("[controller]")]
public class TodosController : ControllerBase
{
    private readonly List<Todo> TODOS = new()
    {
        new Todo(1, "Finish this project."),
        new Todo(2, "Create OAuth + OpenID Connect project."),
        new Todo(3, "Make diagrams on draw.io for auth flows."),
    };

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        await Task.Delay(1);

        return Ok(TODOS);
    }
}
