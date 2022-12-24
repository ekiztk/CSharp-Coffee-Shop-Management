using CoffeShopManagement.Entities;
using CoffeShopManagement.Services.Managers;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CoffeShopManagement.Forms.Additional_Forms
{
    public partial class FrmOrderPayment : Form
    {
        private Order _order;
        List<OrderItem> orderItemList;
        decimal totalPrice = 0;
        public bool IsPaymentSuccesful { get; private set; }

        OrderManager orderManager = new OrderManager();

        public FrmOrderPayment(Order order)
        {
            InitializeComponent();
            _order = order;
            LoadOrderItems();
        }

        void LoadOrderItems()
        {
            orderManager.CreateInstance(true);
            _order = orderManager.Get(c => c.Id == _order.Id);
            orderItemList = _order.OrderItems.ToList();
            if (orderItemList.Count > 0) lblOrderItems.Text = "";
            foreach (OrderItem item in orderItemList)
            {
                lblOrderItems.Text += $"\n1x    {item.Product.Label}";
                totalPrice += item.Product.Price;
            }
            lblWaiterName.Text = _order.Employee.Name;
            orderManager.Dispose();
            lblTotalPrice.Text = totalPrice + "$";
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            IsPaymentSuccesful = true;
            this.Hide();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            IsPaymentSuccesful = false;
            this.Hide();
        }
    }
}
