using CoffeShopManagement.Database.EntityOperations;
using CoffeShopManagement.Entities;
using CoffeShopManagement.Properties;
using CoffeShopManagement.Services.Interfaces;
using System.Drawing;

namespace CoffeShopManagement.Services.Managers
{
    internal class ProductManager : BaseServiceManager<Product, ProductDal>, IProductService
    {
        public Image GetIconOfProduct(Product product)
        {
            return (Image)Resources.ResourceManager.GetObject(product.Name);
        }
    }
}
