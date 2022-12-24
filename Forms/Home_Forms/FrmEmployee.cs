using CoffeShopManagement.Entities;
using CoffeShopManagement.Services.Managers;
using System.Windows.Forms;

namespace CoffeShopManagement.Forms.Home_Forms
{
    public partial class FrmEmployee : Form
    {
        Employee _employee;
        EmployeeManager employeeManager = new EmployeeManager();
        public FrmEmployee(Employee employee)
        {
            InitializeComponent();
            this.BackColor = FormDesigner.BackgroundColorWhite;
            _employee = employee;
            LoadEmployee();
        }

        private void LoadEmployee()
        {
            lblSSN.Text = _employee.SocialSecurityNumber.ToString();
            lblName.Text = _employee.Name;
            lblRole.Text = _employee.Role.Label;
            tbxPassword.Text = _employee.Password;
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            btnUpdate.Enabled = false;
            if (tbxPassword.Text != "" && tbxPassword.Text.Length <= 20)
            {
                employeeManager.CreateInstance(true);
                _employee.Password = tbxPassword.Text.Trim();
                employeeManager.Update(_employee);
                employeeManager.Dispose();
                lblSuccesful.Visible = true;
            }
            else
            {
                MessageBox.Show("Şifre boş veya 20 karakterden fazla olamaz.", "Hata!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnUpdate.Enabled = true;

        }
    }
}
