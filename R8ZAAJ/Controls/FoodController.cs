using R8ZAAJ.DAO.OrderDAO;
using R8ZAAJ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
