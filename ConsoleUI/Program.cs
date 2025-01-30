// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

await ProductTestAsync();
await CategoryTestAsync();
await ProductDTOAsync();
static async Task ProductTestAsync()
{
    ProductManager productManager = new(new EfProductDal());

    var result = await productManager.GetAllAsync();
    if (result.Success)
    {
        foreach (var product in result.Data)
        {
            await Console.Out.WriteLineAsync(product.Name);
        }
    }
}

static async Task CategoryTestAsync()
{
    CategoryManager categoryManager = new(new EfCategoryDal());
    var result = await categoryManager.GetAllAsync();
    if (result.Success)
    {
        foreach (var category in result.Data)
        {
            await Console.Out.WriteLineAsync(category.Name);
        }
    }
}

ProductDTOAsync();

static async Task ProductDTOAsync()
{
    ProductManager productManager = new(new EfProductDal());

    var result = await productManager.GetProductDetailsAsync();
    if (result.Success)
    {
        foreach (var product in result.Data)
        {
            await Console.Out.WriteLineAsync(product.Name + " / " + product.CategoryName);
        }
    }
    else
    {
        await Console.Out.WriteLineAsync(result.Message);
    }
}