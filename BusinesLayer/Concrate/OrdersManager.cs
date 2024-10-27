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
    public class OrdersManager : IOrdersService       
    {
        private readonly IOrdersDal _ordersDal;

        public OrdersManager(IOrdersDal ordersDal)
        {
            _ordersDal = ordersDal;
        }

        public void TAdd(Orders entity)
        {
            _ordersDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _ordersDal.Delete(id);
        }

        public List<Orders> TGetAll()
        {
            return _ordersDal.GetAll();
        }

        public Orders TgetById(int id)
        {
            return _ordersDal.getById(id);
        }

        public void TUpdate(Orders entity)
        {
            _ordersDal.Update(entity);
        }
    }
}
