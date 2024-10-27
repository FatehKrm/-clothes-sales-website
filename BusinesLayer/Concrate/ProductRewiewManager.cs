using BusinesLayer.Abstruct;
using DataAccessLayer.Abstruct;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrate
{
    public class ProductRewiewManager : IProductRewiewService
    {
        private readonly IProductRewiewDal _productRewiewDal;

        public ProductRewiewManager(IProductRewiewDal productRewiewDal)
        {
            _productRewiewDal = productRewiewDal;
        }

        public void TAdd(ProductRewiew entity)
        {
            _productRewiewDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _productRewiewDal.Delete(id);
        }

        public List<ProductRewiew> TGetAll()
        {
            return _productRewiewDal.GetAll();
        }

        public ProductRewiew TgetById(int id)
        {
            return _productRewiewDal.getById(id);
        }

        public void TUpdate(ProductRewiew entity)
        {
            _productRewiewDal.Update(entity);
        }
    }
}
