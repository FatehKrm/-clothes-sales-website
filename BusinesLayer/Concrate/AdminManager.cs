using BusinesLayer.Abstruct;
using DataAccessLayer.Abstruct;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrate
{
    public class AdminManager : IAdminService // IAdmin service business katmanında bulunan abstruct klasörü içi
    {

        private readonly IAdminDal _adminDal; // data access layer 

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void TAdd(Admin entity) // TAdd business layer den gelen add methodu Add ise data access layerdan 
        {
            _adminDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _adminDal.Delete(id);
        }

        public List<Admin> TGetAll()
        {
            return _adminDal.GetAll();
        }

        public Admin TgetById(int id)
        {
            return _adminDal.getById(id);
        }

        public void TUpdate(Admin entity)
        {
            _adminDal.Update(entity);
        }
    }
}
