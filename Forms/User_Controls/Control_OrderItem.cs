using CoffeShopManagement.Entities;
using System;
using System.Windows.Forms;

namespace CoffeShopManagement.Forms.User_Controls
{
    public partial class Control_OrderItem : UserControl
    {
        OrderItem _orderItem;
        private readonly Action<OrderItem> deleteProductFromOrderEvent;

        public Control_OrderItem(OrderItem orderItem, Action<OrderItem> DeleteProductFromOrderEvent)
        {
            InitializeComponent();
            _orderItem = orderItem;
            deleteProductFromOrderEvent = DeleteProductFromOrderEvent;
            lblProductName.Text = _orderItem.Product.Label;
            if (_orderItem.IsReady)
            {
                btnRemoveProduct.Visible = false;
            }
        }

        private void btnRemoveProduct_Click(object sender, System.EventArgs e)
        {
            deleteProductFromOrderEvent?.Invoke(_orderItem);
        }
    }
}
