// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

ProductTest();

CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new(new EfProductDal());

    foreach (var product in productManager.GetAll())
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

    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine(product.Name + " / " + product.CategoryName);
    }
}