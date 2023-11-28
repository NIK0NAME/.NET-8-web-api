using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetUsers")]
    public ActionResult<List<User>> GetAll() => UserService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<User> Get(int id)
    {
        var user = UserService.Get(id);

        if (user == null) return NotFound();

        return user;
    }

    [HttpPost]
    public ActionResult Create(User user)
    {
        UserService.Add(user);
        return CreatedAtAction(nameof(Get), new { id = user.id }, user);
    }

    [HttpPut("{id}")]
    public ActionResult Update(int id, User user)
    {
        if (id != user.id) return BadRequest();

        var existingUser = UserService.Get(id);

        if (existingUser == null) return NotFound();

        UserService.Update(user);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var user = UserService.Get(id);

        if (user == null) return NotFound();

        UserService.Delete(id);

        return NoContent();
    }
}
