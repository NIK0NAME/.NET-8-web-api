namespace WebApi.Models.Repository;

public interface IUserRepository
{
    IEnumerable<UserModel> GetUsers();
}