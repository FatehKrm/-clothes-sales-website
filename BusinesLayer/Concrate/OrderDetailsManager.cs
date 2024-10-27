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
    public class OrderDetailsManager : IOrderDetailsService
    {
        private readonly IOrderDetailsDal _orderDetailsDal;

        public OrderDetailsManager(IOrderDetailsDal orderDetailsDal)
        {
            _orderDetailsDal = orderDetailsDal;
        }

        public void TAdd(OrderDetails entity)
        {
            _orderDetailsDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _orderDetailsDal.Delete(id);
        }

        public List<OrderDetails> TGetAll()
        {
            return _orderDetailsDal.GetAll();
        }

        public OrderDetails TgetById(int id)
        {
            return _orderDetailsDal.getById(id);
        }

        public void TUpdate(OrderDetails entity)
        {
            _orderDetailsDal.Update(entity);
        }
    }
}
