// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;


ProductManager productManager = new(new EfProductDal());

foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.Name);
}