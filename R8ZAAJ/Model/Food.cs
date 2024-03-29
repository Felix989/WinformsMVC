﻿using System;

namespace R8ZAAJ.Model
{
    public class Food
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String FoodName { get; set; }
        public int Price { get; set; }
        public float EDT { get; set; }
        public int LoyaltyPoints { get; set; }

        public Food(int id, String name, String foodName, int price, int edt, int loyaltyPoints)
        {
            ID = id;
            Name = name;
            FoodName = foodName;
            Price = price;
            EDT = edt;
            LoyaltyPoints = loyaltyPoints;
        }

    }
}
