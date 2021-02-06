using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _iProductDal;

        public ProductManager(IProductDal iProductDal)
        {
            _iProductDal = iProductDal;
        }

        public List<Product> GetAll()
        {
            return _iProductDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _iProductDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _iProductDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _iProductDal.GetProductDetails();
        }
    }
}