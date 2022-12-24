using CoffeShopManagement.Entities.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeShopManagement.Entities
{
    public class Role : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

    }
}
