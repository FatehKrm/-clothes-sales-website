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
    public class EfTemporanyColorsDal : GenericRepository<TemporanyColors>, ITemporanyColorsDal
    {
        private readonly EticElbiseContext context;
        public EfTemporanyColorsDal(EticElbiseContext context) : base(context)
        {
            this.context = context;
        }

        public void ClearAllFromTColors()
        {
            var values = context.TemporanyColors.ToList();
            if(values.Any()) 
            {
                context.TemporanyColors.RemoveRange(values);
                context.SaveChanges();
            }
        }
       
    }
}

