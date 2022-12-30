using System.Linq.Expressions;

namespace WebApi.Repository
{
    public interface IRepository<TEntity, TKey> where TEntity : class where TKey : struct
    {
        TEntity FindById(TKey id);
        IEnumerable<TEntity> Find();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);

    }
}
