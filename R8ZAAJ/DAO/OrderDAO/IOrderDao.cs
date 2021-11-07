using R8ZAAJ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R8ZAAJ.DAO.OrderDAO
{
    public interface IOrderDao
    {
        List<Food> getAllFood();
        bool MakeAnOrder(User loggedInUser);
        List<Food> getAllOrdersByUser(User user);
    }
}
