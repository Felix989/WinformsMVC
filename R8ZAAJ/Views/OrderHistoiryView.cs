using R8ZAAJ.Controls;
using R8ZAAJ.DAO.OrderDAO;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace R8ZAAJ.Views
{
    public partial class OrderHistoiryView : Form
    {
        private BindingSource _binding;
        private FoodController _food_controller;
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
        public OrderHistoiryView()
        {
            InitializeComponent();
            _food_controller = new(new OrderSQLiteDAO());
            this._binding = new();
            this._binding.DataSource = _food_controller.getAllOrdersByUser(Form1.loggedInUser);
            this.HistoricGrid.DataSource = _food_controller.getAllOrdersByUser(Form1.loggedInUser);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Back(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
