using R8ZAAJ.Controls;
using R8ZAAJ.DAO;
using R8ZAAJ.DAO.OrderDAO;
using R8ZAAJ.Model;
using R8ZAAJ.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (this.UsernameInput.Text != null && this.PasswordInput.Text != null)
            {
                User logger = new User(this.UsernameInput.Text, this.PasswordInput.Text);
                if (_controller.LogInUser(logger))
                {
                    loggedInUser = logger;
                    MessageBox.Show(loggedInUser.Username + " is logged in!");
                    HomeView view = new HomeView();
                    view.Show();
                }
                else
                {
                    MessageBox.Show(logger.Username + " was not found!");
                    new Exception("Wrong Crendentials!");
                }
            }
        }

        private void registerButtonPressed(object sender, EventArgs e)
        {
            if (this.UsernameInput.Text != null && this.PasswordInput.Text != null)
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
        }
    }

    internal class Nullalbe<T>
    {
    }
}
