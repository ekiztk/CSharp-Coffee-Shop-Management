using CoffeShopManagement.Entities.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeShopManagement.Entities
{
    public class Employee : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
