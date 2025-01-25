
using static Entities.Concrete.User;
using Core.Entities;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentCategoryID { get; set; }

        //// Navigation Properties
        //public Category ParentCategory { get; set; }
        //public ICollection<Category> SubCategories { get; set; }
        //public ICollection<Product> Products { get; set; }
    }
}
