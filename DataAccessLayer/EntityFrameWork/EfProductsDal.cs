using DataAccessLayer.Abstruct;
using DataAccessLayer.Context;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameWork
{
    public class EfProductsDal : GenericRepository<Products>, IProductsDal
    {
        public EfProductsDal(EticElbiseContext context) : base(context)
        {
        }

    }
}
