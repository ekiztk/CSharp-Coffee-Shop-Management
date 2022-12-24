using CoffeShopManagement.Context;
using CoffeShopManagement.Database.Interfaces;
using CoffeShopManagement.Entities;

namespace CoffeShopManagement.Database.EntityOperations
{
    internal class OrderDal : BaseEntityDal<Order, CoffeShopDBContext>, IOrderDal
    {
    }
}
