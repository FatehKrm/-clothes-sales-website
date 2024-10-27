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
    public class SizeManager : ISizeService
    {
        private readonly ISizeDal _sizedal;

        public SizeManager(ISizeDal sizedal)
        {
            _sizedal = sizedal;
        }

        public void TAdd(Sizes entity)
        {
            _sizedal.Add(entity);
        }

        public void TDelete(int id)
        {
            _sizedal.Delete(id);
        }

        public List<Sizes> TGetAll()
        {
            return _sizedal.GetAll();
        }

        public Sizes TgetById(int id)
        {
            return _sizedal.getById(id);
        }

        public void TUpdate(Sizes entity)
        {
            _sizedal.Update(entity);
        }
    }
}
