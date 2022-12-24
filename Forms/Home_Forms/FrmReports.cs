using CoffeShopManagement.Entities;
using CoffeShopManagement.Services.Managers;
using CoffeShopManagement.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CoffeShopManagement.Forms.Home_Forms
{
    public partial class FrmReports : Form
    {
        OrderItemManager orderItemManager = new OrderItemManager();

        List<OrderItem> _orderItemList;
        List<OrderItem> OrderItemList
        {
            get { return _orderItemList; }
            set
            {
                _orderItemList = value;
                CreateOrderItemList(_orderItemList.OrderByDescending(a => a.CreationDate).ToList()); //tarihleri azalana göre sıralayıp oluştur
            }
        }

        decimal totalAmount = 0;

        public FrmReports()
        {
            InitializeComponent();
            this.BackColor = FormDesigner.BackgroundColorWhite;
            LoadOrderItems();
            FillDateCbx();
        }

        private void LoadOrderItems()
        {
            orderItemManager.CreateInstance(true);
            OrderItemList = orderItemManager.List(c => c.IsReady == true);
            orderItemManager.Dispose();
        }
        private void CreateOrderItemList(List<OrderItem> orderItemList)
        {
            totalAmount = 0;
            flpReports.Controls.Clear();
            foreach (OrderItem item in orderItemList)
            {
                OrderItemDetail d = new OrderItemDetail(item);
                flpReports.Controls.Add(d);
                totalAmount += item.Product.Price;
            }
            lblOrderItemCount.Text = orderItemList.Count.ToString();
            lblTotalAmount.Text = totalAmount.ToString() + " $";
        }

        private void FillDateCbx()
        {
            cbxDate.Items.Clear();
            cbxDate.Text = "Tümü";
            cbxDate.Items.Add("Tümü");
            cbxDate.Items.Add("Bugün");
            cbxDate.Items.Add("Bu Hafta");
            cbxDate.Items.Add("Bu Ay");
        }

        private void cbxDate_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string selectedItem = cbxDate.SelectedItem.ToString();
            var today = DateTime.UtcNow;
            LoadOrderItems();
            switch (selectedItem)
            {
                case "Bugün":
                    OrderItemList = OrderItemList.Where(c => c.CreationDate.Date == today.Date).ToList();
                    break;
                case "Bu Hafta":
                    OrderItemList = OrderItemList.Where(c => c.CreationDate.Date >= today.Date.AddDays(-7)).ToList();
                    break;
                case "Bu Ay":
                    OrderItemList = OrderItemList.Where(c => c.CreationDate.Date.Year == today.Date.Year && c.CreationDate.Date.Month == today.Date.Month).ToList();
                    break;
                default:
                    break;
            }
        }

        //servis mimarisi oluşturmada kaldık
    }
}
