using CoffeShopManagement.Entities;
using CoffeShopManagement.Forms;
using CoffeShopManagement.Forms.Others;
using CoffeShopManagement.Services.Managers;
using CoffeShopManagement.User_Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoffeShopManagement.Home_Forms
{
    public partial class FrmKitchen : Form, IRefreshablePage
    {
        OrderItemManager orderItemManager = new OrderItemManager();
        List<OrderItem> orderItemList;

        public event Action<OrderItem> OrderItemStatusChangeEvent;

        public FrmKitchen()
        {
            InitializeComponent();
            this.BackColor = FormDesigner.BackgroundColorWhite;
            OrderItemStatusChangeEvent += ChangeOrderItemStatus;
            LoadOrderItems();
        }
        //mutfak bölümüne başlanacak ve ürünlerin ikonları yüklenecek

        void LoadOrderItems()
        {
            orderItemManager.CreateInstance(true);
            orderItemList = orderItemManager.List(c => c.IsReady == false);
            flpOrders.Controls.Clear();
            if (orderItemList.Count > 0)
            {
                foreach (OrderItem item in orderItemList)
                {
                    OrderItemDetail d = new OrderItemDetail(item, OrderItemStatusChangeEvent);
                    flpOrders.Controls.Add(d);
                }
            }
            else
            {
                CreateNoOrderLabel();
            }

            orderItemManager.Dispose();
        }

        void ChangeOrderItemStatus(OrderItem orderItem)
        {
            orderItemManager.CreateInstance(true);
            orderItemManager.Update(orderItem);
            orderItemManager.Dispose();
            LoadOrderItems();
        }

        void CreateNoOrderLabel()
        {
            Label lbl = new Label();
            lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lbl.Location = new System.Drawing.Point(7, 4);
            lbl.Name = "lblNoOrderItem";
            lbl.Size = new System.Drawing.Size(912, 32);
            lbl.TabIndex = 11;
            lbl.Text = "Aktif Sipariş Yok.";
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            flpOrders.Controls.Add(lbl);
        }

        public void RefreshPageForDatabaseUpdate()
        {
            LoadOrderItems();
        }
    }
}
