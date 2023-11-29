using WebApi.Models;
using WebApi.Models.Repository;

namespace WebApi.Services;

public class UserService
{
    private UserRepository _userRepository;

    public UserService(UserRepository userRepository)
    {   _userRepository = userRepository;

    }

    public IEnumerable<UserModel> GetAll() =>  _userRepository.GetUsers();

    public User? Get(int id)
    {
        throw new NotImplementedException();
    }

    public  void Add(User user)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(User user)
    {
        throw new NotImplementedException();
    }
}