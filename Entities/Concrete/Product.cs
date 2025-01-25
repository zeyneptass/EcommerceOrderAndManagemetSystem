using Core.Entities;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsActive { get; set; }

        //// Navigation Properties
        //public Category Category { get; set; }
        //public ICollection<ProductImage> ProductImages { get; set; }
        //public ICollection<OrderItem> OrderItems { get; set; }
        //public ICollection<CartItem> CartItems { get; set; }
    }
}
