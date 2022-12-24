using CoffeShopManagement.Entities;
using System;
using System.Windows.Forms;

namespace CoffeShopManagement.User_Controls
{
    public partial class OrderItemDetail : UserControl
    {
        OrderItem _orderItem;
        private readonly Action<OrderItem> orderItemStatusChangeEvent;

        public OrderItemDetail(OrderItem orderItem, Action<OrderItem> OrderItemStatusChangeEvent = null)
        {
            InitializeComponent();
            _orderItem = orderItem;
            if (_orderItem.IsReady) { btnReady.Visible = false; }
            LoadOrderItem();
            orderItemStatusChangeEvent = OrderItemStatusChangeEvent;
        }

        private void LoadOrderItem()
        {
            lblOrderId.Text = _orderItem.Id.ToString();
            lblDeskNumber.Text = _orderItem.Order.DeskNumber.ToString();
            lblCreationDate.Text = _orderItem.CreationDate.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            lblProduct.Text = _orderItem.Product.Label;
            lblOrderItemPrice.Text = _orderItem.Product.Price + " $";
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            _orderItem.IsReady = true;
            orderItemStatusChangeEvent?.Invoke(_orderItem);
        }
    }
}
