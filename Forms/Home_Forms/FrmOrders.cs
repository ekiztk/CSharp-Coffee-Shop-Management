using CoffeShopManagement.Entities;
using CoffeShopManagement.Forms.Others;
using CoffeShopManagement.Forms.User_Controls;
using CoffeShopManagement.Services.Managers;
using System.Linq;
using System.Windows.Forms;

namespace CoffeShopManagement.Forms.Home_Forms
{
    public partial class FrmOrders : Form, IRefreshablePage
    {
        OrderManager orderManager = new OrderManager();
        private Employee _employee;
        private int deskCount = 6;


        public FrmOrders(Employee employee)
        {
            InitializeComponent();
            this.BackColor = FormDesigner.BackgroundColorWhite;
            _employee = employee;
            CreateDesks();
        }

        public void RefreshPageForDatabaseUpdate()
        {
            CreateDesks();
        }

        //Başlangıçta masaları oluştur
        private void CreateDesks()
        {
            tblDesks.Controls.Clear();
            orderManager.CreateInstance(true);
            var orderList = orderManager.List();
            for (int i = 0; i < deskCount; i++)
            {
                int deskNumber = i + 1;
                Desk d;
                //eğer masa numarası var ise ve masa açıksa bilgileri gönder yoksa null gönder
                if (orderList.Any<Order>(c => c.IsClosed == false && c.DeskNumber == deskNumber))
                {
                    d = new Desk(_employee, orderList.First(c => c.DeskNumber == deskNumber && c.IsClosed == false), deskNumber);
                }
                else
                {
                    d = new Desk(_employee, null, deskNumber);
                }

                tblDesks.Controls.Add(d);
                orderManager.Dispose();
            }
        }

    }
}
