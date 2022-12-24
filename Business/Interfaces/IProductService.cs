using CoffeShopManagement.Entities;
using System.Drawing;

namespace CoffeShopManagement.Services.Interfaces
{
    internal interface IProductService : IServiceTemplate<Product>
    {
        Image GetIconOfProduct(Product product); //ürün ikonunu resim olarak döndürür
    }
}
