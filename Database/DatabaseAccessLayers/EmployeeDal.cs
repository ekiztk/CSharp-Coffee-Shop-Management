using CoffeShopManagement.Context;
using CoffeShopManagement.Database.Interfaces;
using CoffeShopManagement.Entities;

namespace CoffeShopManagement.Database.EntityOperations
{
    internal class EmployeeDal : BaseEntityDal<Employee, CoffeShopDBContext>, IEmployeeDal
    {
    }
}
