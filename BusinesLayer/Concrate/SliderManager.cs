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
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void TAdd(Slider entity)
        {
            _sliderDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _sliderDal.Delete(id);
        }
        public List<Slider> TGetAll()
        {
            return _sliderDal.GetAll();
        }

        public Slider TgetById(int id)
        {
            return _sliderDal.getById(id);
        }

        public void TUpdate(Slider entity)
        {
            _sliderDal.Update(entity);  
        }
    }
}
