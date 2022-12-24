using CoffeShopManagement.Entities.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeShopManagement.Entities
{
    public class Order : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int DeskNumber { get; set; }
        public bool IsClosed { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
