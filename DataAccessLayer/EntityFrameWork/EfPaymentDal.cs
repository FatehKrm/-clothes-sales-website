using DataAccessLayer.Abstruct;
using DataAccessLayer.Context;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameWork
{
    public class EfPaymentDal : GenericRepository<Payments>, IPaymentsDal
    {
        public EfPaymentDal(EticElbiseContext context) : base(context)
        {
        }
    }
}
