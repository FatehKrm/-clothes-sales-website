using DataAccessLayer.Abstruct;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly EticElbiseContext _Context;

        public GenericRepository(EticElbiseContext context)
        {
            _Context = context;
        }

        public void Add(T entity)
        {
            _Context.Set<T>().Add(entity);
            _Context.SaveChanges();
        }

        public void Delete(int id)
        {
            var values = _Context.Set<T>().Find(id);
            _Context.Set<T>().Remove(values);
            _Context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _Context.Set<T>().ToList();
        }

        public T getById(int id)
        {
            return _Context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _Context.Set<T>().Update(entity);
            _Context.SaveChanges();
        }
    }
}
