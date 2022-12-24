using CoffeShopManagement.Entities;
using CoffeShopManagement.Services.Managers;
using System;
using System.Windows.Forms;

namespace CoffeShopManagement.Forms
{
    public partial class FrmLogIn : Form
    {
        EmployeeManager employeeManager = new EmployeeManager();
        public FrmLogIn()
        {
            InitializeComponent();
            //-----------Database Oluşturmak-----------
            //CoffeShopDBContext c = new CoffeShopDBContext();
            //c.Database.CreateIfNotExists();
            //-----------------------------------------
            this.BackColor = FormDesigner.BackgroundColor;
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            employeeManager.CreateInstance(true); //Databaseye bağlantı nesnesini oluştur
            lblWait.Visible = true;
            btnLogin.Enabled = false;
            int ssn = Convert.ToInt32(tbxSSN.Text.Trim());
            bool isUserExist = employeeManager.Exist(c => c.SocialSecurityNumber == ssn && c.Password == tbxPassword.Text.Trim());
            if (isUserExist)
            {
                Employee _employee = employeeManager.Get(c => c.SocialSecurityNumber == ssn);
                FrmHomepage homepage = new FrmHomepage(_employee);
                homepage.Show();
                this.Hide();
                employeeManager.Dispose();
            }
            else
            {
                btnLogin.Enabled = true;
                MessageBox.Show("Bu sosyal güvenlik numarası veya şifre yanlış lütfen tekrar deneyin.", "Çalışan bulunamadı!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblWait.Visible = false;
        }
    }
}
