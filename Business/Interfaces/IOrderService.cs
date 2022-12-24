using CoffeShopManagement.Entities;

namespace CoffeShopManagement.Services.Interfaces
{
    internal interface IOrderService : IServiceTemplate<Order>
    {
        bool CheckIfOrderItemsAreCompleted(int orderId);
    }
}
