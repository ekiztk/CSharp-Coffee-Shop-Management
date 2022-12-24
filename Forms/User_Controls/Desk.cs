using CoffeShopManagement.Entities;
using CoffeShopManagement.Forms.Additional_Forms;
using CoffeShopManagement.Services.Managers;
using System.Windows.Forms;
using Order = CoffeShopManagement.Entities.Order;

namespace CoffeShopManagement.Forms.User_Controls
{
    public partial class Desk : UserControl
    {
        private Order _order = null;
        private int DeskNumber { get; set; }

        private Employee _employee;

        OrderManager orderManager = new OrderManager();

        public Desk(Employee employee, Order order, int deskNumber = 0)
        {
            InitializeComponent();
            DeskNumber = deskNumber;
            _employee = employee;
            lblDeskNumber.Text = "MASA " + DeskNumber.ToString();
            _order = order;
            LoadOrder();
        }

        //Sipariş bilgilerini yükle
        private void LoadOrder()
        {
            orderManager.CreateInstance(true);
            if (_order == null)
            {
                foreach (Button item in pnlButtons.Controls)
                {
                    item.Visible = false;
                }
                lblWaiterName.Visible = false;
                lblWaiter.Visible = false;
                btnCreateOrder.Visible = true;
            }
            else
            {
                foreach (Button item in pnlButtons.Controls)
                {
                    item.Visible = true;
                }
                lblWaiterName.Visible = true;
                lblWaiter.Visible = true;
                lblWaiterName.Text = orderManager.Get(c => c.Id == _order.Id).Employee.Name;
                btnCreateOrder.Visible = false;
                if (_order.EmployeeId != _employee.Id)
                {
                    foreach (Button item in pnlButtons.Controls)
                    {
                        item.Enabled = false;
                    }
                }
            }
            orderManager.Dispose();
        }

        private void btnCreateOrder_Click(object sender, System.EventArgs e)
        {
            orderManager.CreateInstance(true);
            Order order = new Order();
            order.DeskNumber = DeskNumber;
            order.EmployeeId = _employee.Id;
            orderManager.AddOrUpdate(order);
            _order = order;
            orderManager.Dispose();
            LoadOrder();
        }
        private void btnCloseOrder_Click(object sender, System.EventArgs e)
        {
            orderManager.CreateInstance(true);
            bool closingCondition = orderManager.CheckIfOrderItemsAreCompleted(_order.Id);
            orderManager.Dispose();
            if (closingCondition) //eğer tamamlanmamış sipariş yoksa
            {
                FrmOrderPayment frmOrderPayment = new FrmOrderPayment(_order);
                frmOrderPayment.ShowDialog();
                if (frmOrderPayment.IsPaymentSuccesful)
                {
                    orderManager.CreateInstance(true);
                    _order.IsClosed = true;
                    orderManager.Update(_order);
                    _order = null;
                    LoadOrder();
                    orderManager.Dispose();
                }
                frmOrderPayment.Close();
            }
            else
            {
                MessageBox.Show("Bu masaya ait tamamlanmamış sipariş var lütfen tamamlayın.", "Hata!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditOrder_Click(object sender, System.EventArgs e)
        {
            if (_order != null)
            {
                FrmOrderDetail frmOrderDetail = new FrmOrderDetail(_order);
                frmOrderDetail.ShowDialog();
            }
        }
    }
}
