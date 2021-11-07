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

            PriceTag.Text = CalculateBasketsWorth(Form1.loggedInUser).ToString();
        }


        public int CalculateBasketsWorth(User user)
        {
            if(user.Basket != null)
            {
                int worth = user.Basket.Sum(x => x.Price);
                return worth;
            }
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
            }
        }
    }
}
