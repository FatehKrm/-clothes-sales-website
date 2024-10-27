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
    public class EfColorsDal : GenericRepository<Colors>, IColorsDal
    {
        public EfColorsDal(EticElbiseContext context) : base(context)
        {
        }
    }
}
