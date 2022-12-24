using CoffeShopManagement.Context;
using CoffeShopManagement.Database.Interfaces;
using CoffeShopManagement.Entities;

namespace CoffeShopManagement.Database.EntityOperations
{
    internal class ProductDal : BaseEntityDal<Product, CoffeShopDBContext>, IProductDal
    {
    }
}
