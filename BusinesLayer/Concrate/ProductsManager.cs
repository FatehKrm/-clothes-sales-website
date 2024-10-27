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
    public class ProductsManager : IProductsService
    {
        private readonly IProductsDal _productsDal;

        public ProductsManager(IProductsDal productsDal)
        {
            _productsDal = productsDal;
        }

        public void TAdd(Products entity)
        {
            _productsDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _productsDal.Delete(id);
        }

        public List<Products> TGetAll()
        {
            return _productsDal.GetAll();
        }

        public Products TgetById(int id)
        {
            return _productsDal.getById(id);
        }

        public void TUpdate(Products entity)
        {
            _productsDal.Update(entity);
        }
    }
}
