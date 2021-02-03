using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
    }
}