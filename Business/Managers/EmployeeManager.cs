using CoffeShopManagement.Database.EntityOperations;
using CoffeShopManagement.Entities;
using CoffeShopManagement.Services.Interfaces;

namespace CoffeShopManagement.Services.Managers
{
    internal class EmployeeManager : BaseServiceManager<Employee, EmployeeDal>, IEmployeeService
    {
    }
}
