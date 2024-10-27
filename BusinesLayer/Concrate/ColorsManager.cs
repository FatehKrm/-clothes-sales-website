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
    public class ColorsManager : IColorsService
    {
        private readonly IColorsDal _colorDal;

        public ColorsManager(IColorsDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void TAdd(Colors entity)
        {
           _colorDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _colorDal.Delete(id);
        }

        public List<Colors> TGetAll()
        {
           return _colorDal.GetAll();
        }

        public Colors TgetById(int id)
        {
            return _colorDal.getById(id);
        }

        public void TUpdate(Colors entity)
        {
            _colorDal.Update(entity);
        }
    }
}
