using Core.Entities;

namespace Entities.Concrete
{
    public class OrderItem : IEntity
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        //// Navigation Properties
        //public Order Order { get; set; }
        //public Product Product { get; set; }
    }
}
