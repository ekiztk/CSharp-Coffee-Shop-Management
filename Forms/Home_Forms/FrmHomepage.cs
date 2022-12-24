using CoffeShopManagement.Entities;
using CoffeShopManagement.Forms;
using CoffeShopManagement.Forms.Home_Forms;
using CoffeShopManagement.Forms.Others;
using CoffeShopManagement.Home_Forms;
using System.Linq;
using System.Windows.Forms;

namespace CoffeShopManagement
{
    public partial class FrmHomepage : Form
    {
        private Employee _employee;
        private IRefreshablePage _refreshPage; //Güncellemeye uygun formların sahip olduğu interface
        public FrmHomepage(Employee employee = null)
        {
            InitializeComponent();
            this.IsMdiContainer = true; //birden çok forumu içi içe koymaya izin verir
            SetColorsOfControls();
            _employee = employee;
        }

        private void FrmHomepage_Load(object sender, System.EventArgs e)
        {
            LoadRole();
        }

        private void btnOrders_Click(object sender, System.EventArgs e)
        {
            PlaceMdi(new FrmOrders(_employee));

        }

        private void btnKitchen_Click(object sender, System.EventArgs e)
        {
            PlaceMdi(new FrmKitchen());
        }

        private void btnEmployee_Click(object sender, System.EventArgs e)
        {
            PlaceMdi(new FrmEmployee(_employee));
        }

        private void btnReports_Click(object sender, System.EventArgs e)
        {
            PlaceMdi(new FrmReports());
        }

        //Rollere göre izinli oldukları bölümleri göster
        private void LoadRole()
        {
            //Çalışan bilgilerini yazdır
            lblName.Text = _employee.Name;
            lblRole.Text = _employee.Role.Label;
            //Rol yetkisini yükle
            if (_employee.Role.Name == "waiter")
            {
                btnOrders.Visible = true;
                PlaceMdi(new FrmOrders(_employee));
            }
            else if (_employee.Role.Name == "cashier")
            {
                btnOrders.Visible = true;
                btnKitchen.Visible = true;
                btnReports.Visible = true;
                PlaceMdi(new FrmReports());
            }
            else if (_employee.Role.Name == "kitchen")
            {
                btnKitchen.Visible = true;
                PlaceMdi(new FrmKitchen());
            }
        }

        private void SetColorsOfControls()
        {
            //Arkaplan rengini atama
            this.BackColor = FormDesigner.BackgroundColor;
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = FormDesigner.BackgroundColor; //mdi rengini değiştirir
            //Sol menü arkaplan rengini atama
            pnlRoleButtons.BackColor = FormDesigner.BackgroundColorWhite;
            pnlContainer.BackColor = FormDesigner.BackgroundColorWhite;
            //Menu butonların rengini atama
            foreach (Button btn in pnlRoleButtons.Controls)
            {
                btn.BackColor = FormDesigner.ButtonColor;
            }
        }

        //Formları yükler
        private void PlaceMdi(Form form)
        {
            form.MdiParent = this;
            if (pnlContainer.Controls.Count > 0) ((Form)pnlContainer.Controls[0]).Close();
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();

            //Eğer IRefreshPage den kalıtım alıyorsa yenileme fonksiyon ataması yap değilse null yap
            if (form is IRefreshablePage)
            {
                _refreshPage = (IRefreshablePage)form;
            }
            else
            {
                _refreshPage = null;
            }
        }

        private void FrmHomepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Kalıtım kullanarak bir formun yeniden yüklenmesini kontrol eder. Eğer yüklenebiliyorsa her 10 saniyede formu günceller.
        private void RefreshPageTimer_Tick(object sender, System.EventArgs e)
        {
            if (_refreshPage != null)
            {
                this.Cursor = Cursors.WaitCursor;
                _refreshPage.RefreshPageForDatabaseUpdate();
                this.Cursor = Cursors.Default;
            }

        }
    }
}
