using CoffeShopManagement.Database.EntityOperations;
using CoffeShopManagement.Entities;
using CoffeShopManagement.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CoffeShopManagement.Services.Managers
{
    internal class OrderManager : BaseServiceManager<Order, OrderDal>, IOrderService
    {
        public bool CheckIfOrderItemsAreCompleted(int orderId)
        {
            List<OrderItem> orderItems = base.Get(c => c.Id == orderId).OrderItems.ToList();
            //tamamlanmamış sipariş var ise false yok ise true döndür
            return !orderItems.Any(c => c.IsReady == false);
        }
    }
}
