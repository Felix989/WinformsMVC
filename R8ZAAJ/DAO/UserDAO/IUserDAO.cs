using R8ZAAJ.Model;
using System.Collections.Generic;

namespace R8ZAAJ.DAO
{
    public interface IUserDAO
    {
        bool RegisterUser(User user);
        bool LogInUser(User user);
        List<User> GetAllUser();
        List<Food> getOrdersByUser(User user);
    }
}
