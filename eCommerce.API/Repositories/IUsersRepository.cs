using eCommerce.Models;

namespace eCommerce.API.Repositories
{
    public interface IUsersRepository
    {
        List<User> GetUsers();
        User GetUserById(int id);
        User CreateUser(User user);
        User UpdateUser(int id, User user);
        bool DeleteUser(int id);

    }
}
