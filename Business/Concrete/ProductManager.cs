using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task<IResult> AddAsync(Product product)
        {
            if (product.Name.Length < 2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            await _productDal.AddAsync(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public async Task<IDataResult<List<Product>>> GetAllAsync()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            var result = await _productDal.GetAllAsync();
            return new SuccessDataResult<List<Product>>(result, Messages.ProductListed);
        }

        public async Task<IDataResult<List<Product>>> GetAllByCategoryIdAsync(int id)
        {
            var result = await _productDal.GetAllAsync(p => p.CategoryID == id);
            return new SuccessDataResult<List<Product>>(result);
        }

        public async Task<IDataResult<Product>> GetByIdAsync(int productId)
        {
            var result = await _productDal.GetAsync(p => p.ProductID == productId);
            return new SuccessDataResult<Product>(result);
        }

        public async Task<IDataResult<List<Product>>> GetByUnitPriceAsync(decimal min, decimal max)
        {
            var result = await _productDal.GetAllAsync(p => p.Price >= min && p.Price <= max);
            return new SuccessDataResult<List<Product>>(result);
        }

        public async Task<IDataResult<List<ProductDetailDto>>> GetProductDetailsAsync()
        {
            var result = await _productDal.GetProductDetailsAsync();
            return new SuccessDataResult<List<ProductDetailDto>>(result);
        }


    }
}
