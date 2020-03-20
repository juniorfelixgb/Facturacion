using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Data.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        T GetT();
        T GetT(Expression<Func<T, bool>> expression);
        List<T> All();
        bool Save();
    }
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected DbSet<T> _set;
        public FacturacionDbContext DbContext;
        public BaseRepository()
        {
            DbContext = new FacturacionDbContext();
            _set = DbContext.Set<T>();
        }
        public void Add(T entity)
        {
            _set.Add(entity);
        }

        public List<T> All()
        {
            return _set.ToList();
        }

        public void Delete(int id)
        {
            var entidad = GetT(id);
            _set.Remove(entidad);
        }

        public T GetT()
        {
            return _set.FirstOrDefault();
        }

        public T GetT(int id)
        {
            return _set.Find(id);
        }

        public T GetT(Expression<Func<T, bool>> expression)
        {
            return _set.FirstOrDefault(expression);
        }

        public bool Save()
        {
            try
            {
                return DbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Update(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
