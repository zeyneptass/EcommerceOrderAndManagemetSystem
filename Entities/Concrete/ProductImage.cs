using Entities.Abstract;

namespace Entities.Concrete
{
    public class ProductImage : IEntity
    {
        public int ImageID { get; set; }
        public int ProductID { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMain { get; set; }

        //// Navigation Properties
        //public Product Product { get; set; }
    }
}
