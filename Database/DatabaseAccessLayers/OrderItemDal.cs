using CoffeShopManagement.Context;
using CoffeShopManagement.Database.Interfaces;
using CoffeShopManagement.Entities;

namespace CoffeShopManagement.Database.EntityOperations
{
    internal class OrderItemDal : BaseEntityDal<OrderItem, CoffeShopDBContext>, IOrderItemDal
    {
    }
}
