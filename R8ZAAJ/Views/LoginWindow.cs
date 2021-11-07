using R8ZAAJ.Controls;
using R8ZAAJ.DAO;
using R8ZAAJ.Model;
using R8ZAAJ.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace R8ZAAJ
{
    public partial class Form1 : Form
    {
        public static User loggedInUser;
        private UserController _controller;

        public Form1()
        {
            _controller = new(new UserSQLiteDAO());
            InitializeComponent();
        }

        private void loginButtonPressed(object sender, EventArgs e)
        {
            if (this.UsernameInput.Text != null && this.PasswordInput.Text != null && this.UsernameInput.Text != "" && this.PasswordInput.Text != "")
            {
                User logger = new User(this.UsernameInput.Text, this.PasswordInput.Text);
                if (_controller.LogInUser(logger))
                {
                    loggedInUser = logger;
                    loggedInUser.Basket = new List<Food>();
                    MessageBox.Show(loggedInUser.Username + " is logged in!");
                    HomeView view = new HomeView();
                    view.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(logger.Username + " was not found!");
                    new Exception("Wrong Crendentials!");
                }
            }
            else
            {
                //MessageBox.Show("All the fields are required!");
                //new Exception("Wrong Crendentials!");
            }
        }

        private void registerButtonPressed(object sender, EventArgs e)
        {
            if (this.UsernameInput.Text != null && this.PasswordInput.Text != null && this.UsernameInput.Text != "" && this.PasswordInput.Text != "")
            {
                User register = new User(this.UsernameInput.Text, this.PasswordInput.Text);
                if (_controller.RegisterUser(register))
                {
                    MessageBox.Show(register.Username + " was registered!");
                }
                else
                {
                    MessageBox.Show(register.Username + " was not registered!");
                    new Exception("Cannot register user!");
                }
            }
            else
            {
                MessageBox.Show("All the fields are required!");
                new Exception("Wrong Crendentials!");
            }
        }
    }
}
