using R8ZAAJ.Controls;
using R8ZAAJ.DAO.OrderDAO;
using R8ZAAJ.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R8ZAAJ.Views
{
    public partial class HomeView : Form
    {
        private BindingSource _binding;
        private FoodController _food_controller;
        private int SelectedFood;
        public HomeView()
        {
            InitializeComponent();
            _food_controller = new(new OrderSQLiteDAO());
            this._binding = new();
            this._binding.DataSource = _food_controller.getAllFood();
            this.FoodDisplay.DataSource = _food_controller.getAllFood(); // EBBEN LESZNEK A CUCCOK, MAJD MINDIG FRISSíTENI KELL A VIEW-T
            this.Basket.DataSource = Form1.loggedInUser.Basket;

            CalculateBasketsWorth(Form1.loggedInUser);
        }


        public int CalculateBasketsWorth(User user)
        {
            if(user.Basket != null)
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
            if (SelectedFood != null)
            {
                var foods = _food_controller.getAllFood();
                var selected = foods.First(x => x.ID == SelectedFood);
                Form1.loggedInUser.Basket.Add(selected);

                this._binding.DataSource = Form1.loggedInUser.Basket;
                this.Basket.DataSource = Form1.loggedInUser.Basket;
                this.Basket.Update();
                this.Basket.Refresh();
            }
            CalculateBasketsWorth(Form1.loggedInUser);
        }

        private void RemoveItemFromCart(object sender, EventArgs e)
        {
            #pragma warning disable CS0472
            if (SelectedFood != null)
            {
                var foods = _food_controller.getAllFood();
                var selected = foods.First(x => x.ID == SelectedFood);
                Form1.loggedInUser.Basket.Remove(selected);

                this.Basket.DataSource = Form1.loggedInUser.Basket;
                this.Basket.Update();
                this.Basket.Refresh();
            }
            CalculateBasketsWorth(Form1.loggedInUser);
        }

        private void OrderBasket(object sender, EventArgs e)
        {
            _food_controller.MakeAnOrder(Form1.loggedInUser);
            MessageBox.Show("All the foods are ordered!");
        }

        private void ShowPreviousOrders(object sender, EventArgs e)
        {
            //this.Hide();
            OrderHistoiryView view = new OrderHistoiryView();
            view.Show();
        }
    }
}
