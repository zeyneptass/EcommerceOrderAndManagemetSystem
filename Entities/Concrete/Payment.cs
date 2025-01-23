using Entities.Abstract;

namespace Entities.Concrete
{
    public class Payment : IEntity
    {
        public int PaymentID { get; set; }
        public int OrderID { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public string PaymentStatus { get; set; }

        //// Navigation Properties
        //public Order Order { get; set; }
    }
}

