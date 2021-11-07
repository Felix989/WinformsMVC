using R8ZAAJ.Model;
using System.Collections.Generic;

namespace R8ZAAJ.DAO.OrderDAO
{
    public interface IOrderDao
    {
        List<Food> getAllFood();
        bool MakeAnOrder(User loggedInUser);
        List<Food> getAllOrdersByUser(User user);
    }
}
