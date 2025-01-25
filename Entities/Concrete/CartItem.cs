
using Core.Entities;

namespace Entities.Concrete
{
    public class CartItem : IEntity
    {
        public int CartItemID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedAt { get; set; } = DateTime.Now;

        //// Navigation Properties
        //public User User { get; set; }
        //public Product Product { get; set; }

    }
}
