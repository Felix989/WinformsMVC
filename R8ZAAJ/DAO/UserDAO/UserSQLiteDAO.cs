
using R8ZAAJ.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace R8ZAAJ.DAO
{
    class UserSQLiteDAO : IUserDAO
    {
        private readonly String _ConnectionString = @"Data Source = C:\DATA\Programming\GIT\WinformsMVC - GIT\R8ZAAJ\Database\Pizz.db";
        public List<User> GetAllUser()
        {
            List<User> userHolder = new List<User>();

            using SQLiteConnection conn = new SQLiteConnection(_ConnectionString);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "select * from Users";

            using SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var user = new User(reader.GetString(reader.GetOrdinal("UserName")),
                                    reader.GetString(reader.GetOrdinal("Password")));

                userHolder.Add(user);
            }
            conn.Close();
            return userHolder;
        }

        public List<Food> getOrdersByUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool LogInUser(User user)
        {
            bool retbool = false;
            using SQLiteConnection conn = new SQLiteConnection(_ConnectionString);
            conn.Open();
            using SQLiteCommand command = new("select ID from Users where UserName = @un and Password = @pw", conn);
            command.Parameters.AddWithValue("@un", user.Username);
            command.Parameters.AddWithValue("@pw", user.Password);
            command.Prepare();
            using SQLiteDataReader reader = command.ExecuteReader();
            using SQLiteDataAdapter adapter = new(command.CommandText, conn);
            if (reader.Read())
            {
                user.ID = reader.GetInt32("ID");
                retbool = true;
                conn.Close();
            }

            return retbool;
        }

        public bool RegisterUser(User user)
        {

            var userList = GetAllUser();
            var userListName = userList.Select(x => x.Username);

            if (!userListName.Contains(user.Username))
            {

                using SQLiteConnection conn = new SQLiteConnection(_ConnectionString);
                conn.Open();
                using SQLiteCommand command = new("insert into Users(UserName, Password) Values(@un, @pw)", conn);
                command.Parameters.AddWithValue("@un", user.Username);
                command.Parameters.AddWithValue("@pw", user.Password);
                command.Prepare();
                if (command.ExecuteNonQuery() <= 0)
                {
                    conn.Close();
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
