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
    public class UsersManager : IUsersService
    {
        private readonly IUserDal _userDal;

        public UsersManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void TAdd(Users entity)
        {
            _userDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _userDal.Delete(id);
        }

        public List<Users> TGetAll()
        {
            return _userDal.GetAll();
        }

        public Users TgetById(int id)
        {
            return _userDal.getById(id);
        }

        public void TUpdate(Users entity)
        {
            _userDal.Update(entity);
        }
    }
}
