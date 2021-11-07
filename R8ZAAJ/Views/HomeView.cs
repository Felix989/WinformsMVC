using R8ZAAJ.Controls;
using R8ZAAJ.DAO.OrderDAO;
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
        public HomeView()
        {
            InitializeComponent();
            _food_controller = new(new OrderSQLiteDAO());
            this._binding = new();
            this._binding.DataSource = _food_controller.getAllFood();
            this.FoodDisplay.DataSource = this._binding;
        }
    }
}
