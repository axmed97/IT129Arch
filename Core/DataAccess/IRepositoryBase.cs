using Core.Entities.Abstract;
using System.Linq.Expressions;

namespace Core.RepositoryBase;
public interface IRepositoryBase<TEntity>
    where TEntity : class, IEntity
{
    void Add(TEntity entity);
    Task AddAsync(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    List<TEntity> GetAll(Expression<Func<TEntity, bool>>? expression, bool tracking = false);
    TEntity? Get(Expression<Func<TEntity, bool>> expression, bool tracking = false);
    TEntity? GetById(Guid id);
}
