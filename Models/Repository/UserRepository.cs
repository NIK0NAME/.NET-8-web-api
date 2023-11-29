
namespace WebApi.Models.Repository;

public class UserRepository: IUserRepository
{
    protected readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<UserModel> GetUsers()
    {
        return _context.Users.ToList();
    }
}