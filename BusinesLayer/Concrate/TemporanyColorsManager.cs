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
    public class TemporanyColorsManager : ITemporanyColorsService
    {
        private readonly ITemporanyColorsDal _temporanyDal;

        public TemporanyColorsManager(ITemporanyColorsDal temporanyDal)  // constructer 
        {
            _temporanyDal = temporanyDal;
        }

        public void TAdd(TemporanyColors entity)
        {
            _temporanyDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _temporanyDal.Delete(id);
        }

        public List<TemporanyColors> TGetAll()
        {
            return _temporanyDal.GetAll();
        }
        public TemporanyColors TgetById(int id)
        {
            return _temporanyDal.getById(id);
        }

        public void TUpdate(TemporanyColors entity)
        {
            _temporanyDal.Update(entity);
        }

        public void TClearAllFromTColors()
        {
            _temporanyDal.ClearAllFromTColors();
        }
    }
}
