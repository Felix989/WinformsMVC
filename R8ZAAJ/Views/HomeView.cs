using R8ZAAJ.Controls;
using R8ZAAJ.DAO.OrderDAO;
using R8ZAAJ.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace R8ZAAJ.Views
{
    public partial class HomeView : Form
    {
        private BindingSource _binding;
        private FoodController _food_controller;
        private int SelectedFood = int.MaxValue;
        public BindingSource bs = new BindingSource();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

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
        public HomeView()
        {
            InitializeComponent();
            _food_controller = new(new OrderSQLiteDAO());
            this._binding = new();
            this._binding.DataSource = _food_controller.getAllFood();
            this.FoodDisplay.DataSource = _food_controller.getAllFood(); // EBBEN LESZNEK A CUCCOK, MAJD MINDIG FRISSíTENI KELL A VIEW-T
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            CloseThis.BackColor = Color.FromArgb(87, 81, 81);
            CloseThis.FlatStyle = FlatStyle.Flat;
            CloseThis.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            ClearBasketButton.FlatStyle = FlatStyle.Flat;
            ClearBasketButton.FlatAppearance.BorderSize = 0;




            bs.DataSource = Form1.loggedInUser.Basket;
            this.Basket.DataSource = bs;
            //this._binding = new();
            //this._binding.DataSource = Form1.loggedInUser.Basket;
            //this.Basket.DataSource = Form1.loggedInUser.Basket;

            CalculateBasketsWorth(Form1.loggedInUser);
        }


        public int CalculateBasketsWorth(User user)
        {
            if (user.Basket != null)
            {
                int worth = user.Basket.Sum(x => x.Price);
                PriceTag.Text = worth.ToString();
                return worth;
            }
            PriceTag.Text = "0";
            return 0;
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            if (FoodDisplay.SelectedRows.Count > 0)
            {
                SelectedFood = Convert.ToInt32(FoodDisplay.SelectedRows[0].Cells["ID"].Value.ToString());
                string name = FoodDisplay.SelectedRows[0].Cells["FoodName"].Value.ToString();

                SelectedFoodDisplay.Text = name;
            }
        }

        private void AddToBasket(object sender, EventArgs e)
        {
#pragma warning disable CS0472
            if (SelectedFood != null && SelectedFood != 2147483647)
            {
                var foods = _food_controller.getAllFood();
                var selected = foods.First(x => x.ID == SelectedFood);
                Form1.loggedInUser.Basket.Add(selected);

                bs.DataSource = Form1.loggedInUser.Basket;
                this.Basket.DataSource = bs;
                bs.ResetBindings(false);

                //_binding.ResetBindings(false);
                //this._binding = new();
                //this._binding.DataSource = Form1.loggedInUser.Basket;
                //this.Basket.DataSource = Form1.loggedInUser.Basket;
                this.Basket.Update();
                this.Basket.Refresh();
            }
            CalculateBasketsWorth(Form1.loggedInUser);
        }

        private void RemoveItemFromCart(object sender, EventArgs e)
        {
#pragma warning disable CS0472
            if (SelectedFood != null && SelectedFood != 2147483647)
            {
                //var foods = _food_controller.getAllFood();
                //var selected = foods.First(x => x.ID == SelectedFood);
                //Form1.loggedInUser.Basket.Remove(selected);


                //bs.DataSource = Form1.loggedInUser.Basket;
                //this.Basket.DataSource = bs;
                //bs.ResetBindings(false);
                //bs.ResetBindings(false);
                //_binding.ResetBindings(false);
                //this._binding = new();
                //this._binding.DataSource = Form1.loggedInUser.Basket;
                //this.Basket.DataSource = Form1.loggedInUser.Basket;
                //this.Basket.Update();
                //this.Basket.Refresh();
            }
            CalculateBasketsWorth(Form1.loggedInUser);
        }

        private void OrderBasket(object sender, EventArgs e)
        {
            if (Form1.loggedInUser.Basket.Count != 0 && Form1.loggedInUser.Basket.Count != null)
            {
                _food_controller.MakeAnOrder(Form1.loggedInUser);
                CustomPrompt prompt = new CustomPrompt("All the foods are ordered!");
                prompt.ShowDialog();
            }
            else
            {
                CustomPrompt prompt = new CustomPrompt("Cannot order empty basket!");
                prompt.ShowDialog();
            }
        }

        private void ShowPreviousOrders(object sender, EventArgs e)
        {
            //this.Hide();
            OrderHistoiryView view = new OrderHistoiryView();
            view.Show();
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ClearBasketButton_Click(object sender, EventArgs e)
        {
            Form1.loggedInUser.Basket = new List<Food>();

            bs.DataSource = Form1.loggedInUser.Basket;
            this.Basket.DataSource = bs;
            bs.ResetBindings(false);
            this.Basket.Update();
        }
    }
}
