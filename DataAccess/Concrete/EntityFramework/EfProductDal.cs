using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, EcommerceContext>, IProductDal
    {
        public async Task<List<ProductDetailDto>> GetProductDetailsAsync()
        {
            using (EcommerceContext context = new())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryID equals c.CategoryID
                             select new ProductDetailDto
                             {
                                 ProductID = p.ProductID,
                                 Name = p.Name,
                                 CategoryName = c.Name,
                                 StockQuantity = p.StockQuantity
                             };

                return await result.ToListAsync();
            }
        }
    }
}
