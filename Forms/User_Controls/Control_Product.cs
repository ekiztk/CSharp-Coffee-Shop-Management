using CoffeShopManagement.Entities;
using CoffeShopManagement.Services.Managers;
using System;
using System.Windows.Forms;

namespace CoffeShopManagement.Forms.User_Controls
{
    public partial class Control_Product : UserControl
    {
        Product _product;

        private readonly Action<Product> addProductToOrderEvent;

        ProductManager productManager = new ProductManager();

        public Control_Product(Product product, Action<Product> addProductToOrderEvent)
        {
            InitializeComponent();
            _product = product;
            this.addProductToOrderEvent = addProductToOrderEvent;
            lblProductName.Text = product.Label;
            pbxProductLogo.Image = productManager.GetIconOfProduct(_product);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            addProductToOrderEvent?.Invoke(_product); //eventi ateşle
        }
    }
}
