using R8ZAAJ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
