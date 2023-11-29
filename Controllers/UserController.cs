using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Models.Repository;
using WebApi.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private IUserRepository _userRepository;

    public UserController(
        ILogger<UserController> logger,
        IUserRepository userRepository
    )
    {
        _logger = logger;
        _userRepository = userRepository;
    }

    [HttpGet(Name = "GetUsers")]
    public IEnumerable<UserModel> GetAll() => _userRepository.GetUsers();

    [HttpGet("{id}")]
    public ActionResult<User> Get(int id)
    {
        throw new NotImplementedException();
        // var user = _userRepository.Get(id);

        // if (user == null) return NotFound();

        // return user;
    }

    [HttpPost]
    public ActionResult Create(User user)
    {
        throw new NotImplementedException();
        // _userRepository.Add(user);
        // return CreatedAtAction(nameof(Get), new { id = user.id }, user);
    }

    [HttpPut("{id}")]
    public ActionResult Update(int id, User user)
    {
        if (id != user.id) return BadRequest();

        throw new NotImplementedException();

        // var existingUser = _userRepository.Get(id);

        // if (existingUser == null) return NotFound();

        // _userRepository.Update(user);

        // return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        throw new NotImplementedException();
        // var user = _userRepository.Get(id);

        // if (user == null) return NotFound();

        // _userRepository.Delete(id);

        // return NoContent();
    }
}
