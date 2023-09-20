using eCommerce.Models;

namespace eCommerce.API.Repositories
{
    public class UserRepository : IUsersRepository
    {
        public static List<User> _dbMock = new List<User>();
      
        public User CreateUser(User user)
        {
            _dbMock.Add(user);
            return user;
        }

        public bool DeleteUser(int id)
        {
          if (_dbMock.Find(user => user.Id == id) != null) {
            _dbMock.Remove(_dbMock.Find(user => user.Id == id));
            return true;
          }
            return false;
        }

        public User GetUserById(int id)
        {
            return _dbMock.Find(user => user.Id == id);
        }

        public List<User> GetUsers()
        {
            return _dbMock;
        }

        public User UpdateUser(int id, User user)
        {
            _dbMock.Remove(_dbMock.Find(user => user.Id == id));
            _dbMock.Add(user);
            return user;
        }
    }
}
