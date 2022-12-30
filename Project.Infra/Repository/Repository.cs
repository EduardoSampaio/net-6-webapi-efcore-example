using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Xml.Linq;
using WebApi.EF;

namespace WebApi.Repository
{
    public class Repository<TEntity, Tkey> : IRepository<TEntity, Tkey> where TEntity : class where Tkey : struct
    {
        protected readonly MyContext _context;
        public Repository(MyContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {   
            _context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public IEnumerable<TEntity> Find()
        {
            return _context.Set<TEntity>().AsEnumerable();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).AsEnumerable();
        }

        public TEntity FindById(Tkey id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Set<TEntity>().Update(entity);
        }
    }
}
