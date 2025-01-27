// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

ProductTest();

CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new(new EfProductDal());

    foreach (var product in productManager.GetAll().Data)
    {
        Console.WriteLine(product.Name);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.Name);
    }
}

ProductDTO();

static void ProductDTO()
{
    ProductManager productManager = new(new EfProductDal());
    var result = productManager.GetProductDetails();
    if (result.Success ==true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.Name + " / " + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}