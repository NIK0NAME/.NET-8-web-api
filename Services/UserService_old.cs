using WebApi.Models;

namespace WebApi.Services;

public static class UserServiceOld
{
    static List<User> Users { get; }
    static int nextId = 3;

    static UserServiceOld()
    {
        Users = new List<User>
        {
            new User{ id = 1, username = "antonio", email = "ant@hotmail.com", avatar = "None", birthDate = "1994/04/23" },
            new User{ id = 2, username = "Wanillou", email = "wan@gmail.com", avatar = "None", birthDate = "1995/08/03" },
        };
    }

    public static List<User> GetAll() => Users;

    public static User? Get(int id) => Users.FirstOrDefault(u => u.id == id);

    public static void Add(User user)
    {
        user.id = nextId++;
        Users.Add(user);
    }

    public static void Delete(int id)
    {
        var user = Get(id);

        if (user is null) return;

        Users.Remove(user);
    }

    public static void Update(User user)
    {
        var index = Users.FindIndex(u => u.id == user.id);

        if (index == -1) return;

        Users[index] = user;
    }
}