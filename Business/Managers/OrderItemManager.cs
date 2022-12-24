using CoffeShopManagement.Database.EntityOperations;
using CoffeShopManagement.Entities;
using CoffeShopManagement.Services.Interfaces;

namespace CoffeShopManagement.Services.Managers
{
    internal class OrderItemManager : BaseServiceManager<OrderItem, OrderItemDal>, IOrderItemService
    {
    }
}
