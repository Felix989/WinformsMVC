﻿using R8ZAAJ.DAO;
using R8ZAAJ.Model;
using System.Collections.Generic;

namespace R8ZAAJ.Controls
{
    class UserController
    {
        private IUserDAO _dao;

        public UserController(IUserDAO dao)
        {
            _dao = dao;
        }

        public bool RegisterUser(User user) => _dao.RegisterUser(user);
        public bool LogInUser(User user) => _dao.LogInUser(user);
        public List<User> GetAllUser() => _dao.GetAllUser();
    }
}
