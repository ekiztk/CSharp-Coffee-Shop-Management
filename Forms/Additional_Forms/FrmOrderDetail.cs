using CoffeShopManagement.Entities;
using CoffeShopManagement.Forms.User_Controls;
using CoffeShopManagement.Services.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CoffeShopManagement.Forms.Additional_Forms
{
    public partial class FrmOrderDetail : Form
    {
        private Order _order;
        private Category _currentCategory;
        private int categoryIndex = 0;
        private decimal totalPrice = 0;
        List<OrderItem> orderItemList;
        List<Product> productList;
        List<Category> categoryList;

        public Category Category
        {
            get { return _currentCategory; }
            set
            {
                _currentCategory = value;
                ChangeCategoryAndLoadProducts(_currentCategory);//kategori değeri her değişince bu fonksiyonu çağırılacak
            }
        }

        public event Action<Product> AddProductToOrderEvent; //siparişe ürün ekleneceği zaman bu event ateşlenecek
        public event Action<OrderItem> DeleteProductFromOrderEvent; //siparişten ürün silineceği zaman bu event ateşlenecek

        OrderManager orderManager = new OrderManager();
        OrderItemManager orderItemManager = new OrderItemManager();
        ProductManager productManager = new ProductManager();
        CategoryManager categoryManager = new CategoryManager();

        public FrmOrderDetail(Order order)
        {
            InitializeComponent();
            _order = order;
            AddProductToOrderEvent += AddProductToOrder; //Event ateşlendiğinde çalışacak fonksiyon ataması
            DeleteProductFromOrderEvent += DeleteProductFromOrder; //Event ateşlendiğinde çalışacak fonksiyon ataması
            LoadCategoriesOfCoffeShop();
            Category = categoryList[0];
            LoadOrderItemsOfOrder();
        }

        private void LoadOrderItemsOfOrder()
        {
            orderManager.CreateInstance(true);
            if (_order != null)
            {
                totalPrice = 0;
                flpOrderItems.Controls.Clear();
                orderItemList = orderManager.Get(c => c.Id == _order.Id).OrderItems.ToList();
                foreach (OrderItem item in orderItemList)
                {
                    Control_OrderItem p = new Control_OrderItem(item, DeleteProductFromOrderEvent);
                    flpOrderItems.Controls.Add(p);
                    totalPrice += item.Product.Price; //adisyon hesapla
                }
            }
            orderManager.Dispose();
            lblTotalPrice.Text = totalPrice.ToString() + " $";
        }

        private void LoadCategoriesOfCoffeShop()
        {
            categoryManager.CreateInstance(true);
            categoryList = categoryManager.List();
            categoryManager.Dispose();
        }

        private void ChangeCategoryAndLoadProducts(Category category)
        {
            lblCategoryName.Text = category.Label;
            productManager.CreateInstance(true);
            productList = productManager.List(c => c.Category.Id == category.Id);
            tblProducts.Controls.Clear();
            foreach (Product item in productList)
            {
                Control_Product cp = new Control_Product(item, AddProductToOrderEvent);
                tblProducts.Controls.Add(cp);
            }
            productManager.Dispose();
        }

        private void AddProductToOrder(Product product)
        {
            orderItemManager.CreateInstance(true);
            OrderItem orderItem = new OrderItem();
            orderItem.CreationDate = DateTime.UtcNow;
            orderItem.IsReady = false;
            orderItem.ProductId = product.Id;
            orderItem.OrderId = _order.Id;
            orderItemManager.Add(orderItem);
            orderItemManager.Dispose();
            LoadOrderItemsOfOrder();
        }

        private void DeleteProductFromOrder(OrderItem orderItem)
        {
            orderItemManager.CreateInstance(true);
            orderItemManager.Delete(c => c.Id == orderItem.Id);
            orderItemManager.Dispose();
            LoadOrderItemsOfOrder();
        }

        private void btnNextCategory_Click(object sender, System.EventArgs e)
        {
            categoryIndex = (categoryIndex + 1) % categoryList.Count;
            ChangeCategoryAndLoadProducts(categoryList[categoryIndex]);
        }

        private void btnPreviousCategory_Click(object sender, System.EventArgs e)
        {
            if (categoryIndex == 0)
            {
                categoryIndex = categoryList.Count - 1;
            }
            else
            {
                categoryIndex = categoryIndex - 1;
            }
            ChangeCategoryAndLoadProducts(categoryList[categoryIndex]);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
