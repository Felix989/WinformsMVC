using R8ZAAJ.DAO.OrderDAO;
using R8ZAAJ.Model;
using System.Collections.Generic;

namespace R8ZAAJ.Controls
{
    class FoodController
    {
        private IOrderDao _dao;
        public FoodController(IOrderDao dao)
        {
            _dao = dao;
        }

        public List<Food> getAllFood() => _dao.getAllFood();
        public bool MakeAnOrder(User loggedInUser) => _dao.MakeAnOrder(loggedInUser);
        public List<Food> getAllOrdersByUser(User user) => _dao.getAllOrdersByUser(user);
    }
}
