using R8ZAAJ.Controls;
using R8ZAAJ.DAO;
using R8ZAAJ.Model;
using R8ZAAJ.Views;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace R8ZAAJ
{
    public partial class Form1 : Form
    {
        public static User loggedInUser;
        private UserController _controller;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Form1()
        {
            _controller = new(new UserSQLiteDAO());
            InitializeComponent();
            this.PasswordInput.PasswordChar = '*';
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
                    CustomPrompt prompt = new CustomPrompt(loggedInUser.Username + " is logged in!");
                    prompt.ShowDialog();
                    HomeView view = new HomeView();
                    this.Hide();
                    view.Show();
                }
                else
                {
                    CustomPrompt prompt = new CustomPrompt(logger.Username + " was not found!");
                    prompt.ShowDialog();
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
                    CustomPrompt prompt = new CustomPrompt(register.Username + " was registered!");
                    prompt.ShowDialog();
                }
                else
                {
                    CustomPrompt prompt = new CustomPrompt(register.Username + " was not registered!");
                    prompt.ShowDialog();
                    new Exception("Cannot register user!");
                }
            }
            else
            {
                CustomPrompt prompt = new CustomPrompt("All the fields are required!");
                prompt.ShowDialog();
                new Exception("Wrong Crendentials!");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
