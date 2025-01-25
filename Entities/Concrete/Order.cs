using Core.Entities;
using static Entities.Concrete.User;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public int ShippingAddressID { get; set; }
        public decimal TotalAmount { get; set; }
        public string OrderStatus { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //// Navigation Properties
        //public User User { get; set; }
        //public Address ShippingAddress { get; set; }
        //public ICollection<OrderItem> OrderItems { get; set; }
        //public Payment Payment { get; set; }

    }
}
