using Entities.Abstract;

namespace Entities.Concrete
{
    public class Address : IEntity
    {
        public int AddressID { get; set; }
        public int UserID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public bool IsDefault { get; set; }

        //// Navigation Properties
        //public User User { get; set; }
    }
}
