﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R8ZAAJ.Model
{
    public class User
    {
        public int ID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public List<Food> Basket { get; set; }

        public User(String name, String pw)
        {
            Username = name;
            Password = pw;
        }

        public User(int id, String name, String pw)
        {
            ID = id;
            Username = name;
            Password = pw;
        }

        public override string ToString()
        {
            return "ID: " + this.ID + "; Name: " + this.Username +"; Password: " + this.Password;
        }
    }
}
