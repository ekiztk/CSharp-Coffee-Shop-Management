using CoffeShopManagement.Entities.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace CoffeShopManagement.Entities
{
    public class OrderItem : IEntity
    {
        [Key]
        public int Id { get; set; }
        public bool IsReady { get; set; }
        public DateTime CreationDate { get; set; } //UtcNow kullanılacak
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
