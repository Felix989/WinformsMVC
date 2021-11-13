using R8ZAAJ.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace R8ZAAJ.DAO.OrderDAO
{
    class OrderSQLiteDAO : IOrderDao
    {
        private readonly String _ConnectionString = "Data Source=" + Path.Join(AppContext.BaseDirectory.Replace("bin\\Debug\\net5.0-windows\\", ""), @"Database\Pizz.db; Version = 3");
        public List<Food> getAllFood()
        {
            List<Food> foodHolder = new List<Food>();

            using SQLiteConnection conn = new SQLiteConnection(_ConnectionString);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "select * from Foods";

            using SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var food = new Food(reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader.GetString(reader.GetOrdinal("Name")),
                                    reader.GetString(reader.GetOrdinal("FoodName")),
                                    reader.GetInt32(reader.GetOrdinal("Price")),
                                    reader.GetInt32(reader.GetOrdinal("ExpectedShipping")),
                                    reader.GetInt32(reader.GetOrdinal("Points"))
                                    );
                foodHolder.Add(food);
            }
            conn.Close();
            return foodHolder;
        }

        public List<Food> getAllOrdersByUser(User user)
        {
            List<Food> foodHolder = new List<Food>();

            using SQLiteConnection conn = new SQLiteConnection(_ConnectionString);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "select * from Foods " +
                                    "inner join Orders ON Foods.ID = Orders.FoodID " +
                                    "inner join Users ON Orders.UserID = Users.ID where Users.ID = @id";

            command.Parameters.AddWithValue("@ID", user.ID);
            using SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var food = new Food(reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader.GetString(reader.GetOrdinal("Name")),
                                    reader.GetString(reader.GetOrdinal("FoodName")),
                                    reader.GetInt32(reader.GetOrdinal("Price")),
                                    reader.GetInt32(reader.GetOrdinal("ExpectedShipping")),
                                    reader.GetInt32(reader.GetOrdinal("Points"))
                                    );
                foodHolder.Add(food);
            }
            conn.Close();

            foreach (var food in foodHolder)
            {
                var count = 0;
                foreach (var foodtwo in foodHolder)
                {
                    if (food.ID == foodtwo.ID)
                    {
                        count++;
                    }
                }
                food.LoyaltyPoints *= count;
                if (count > 10) count = 10;
                food.EDT *= 1-(Extension.Map(count, 0, 10, 0, 30)/100);
            }
            return foodHolder;
        }

        public bool MakeAnOrder(User loggedInUser)
        {
            using SQLiteConnection conn = new SQLiteConnection(_ConnectionString);
            conn.Open();
            foreach (var item in loggedInUser.Basket)
            {

                using SQLiteCommand command = new("insert into Orders(UserID, FoodID) Values(@userID, @foodID)", conn);
                command.Parameters.AddWithValue("@userID", loggedInUser.ID);
                command.Parameters.AddWithValue("@foodID", item.ID);
                if (command.ExecuteNonQuery() <= 0)
                {
                    conn.Close();
                    return false;
                }
            }
            conn.Close();
            return true;
        }
    }
}
