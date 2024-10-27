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
    public class PaymentsManager : IPaymentsService
    {
        private readonly IPaymentsDal _paymentsDal;

        public PaymentsManager(IPaymentsDal paymentsDal)
        {
            _paymentsDal = paymentsDal;
        }

        public void TAdd(Payments entity)
        {
            _paymentsDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _paymentsDal.Delete(id);
        }

        public List<Payments> TGetAll()
        {
           return _paymentsDal.GetAll();
        }

        public Payments TgetById(int id)
        {
            return _paymentsDal.getById(id);
        }

        public void TUpdate(Payments entity)
        {
            _paymentsDal.Update(entity);
        }
    }
}
