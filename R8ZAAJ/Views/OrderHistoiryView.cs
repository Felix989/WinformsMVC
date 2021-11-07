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
    public partial class OrderHistoiryView : Form
    {
        private BindingSource _binding;
        private FoodController _food_controller;
        public OrderHistoiryView()
        {
            InitializeComponent();
            _food_controller = new(new OrderSQLiteDAO());
            this._binding = new();
            this._binding.DataSource = _food_controller.getAllOrdersByUser(Form1.loggedInUser);
            this.HistoricGrid.DataSource = _food_controller.getAllOrdersByUser(Form1.loggedInUser);
        }

        private void Back(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
