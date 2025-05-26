using Core.Entities.Abstract;
using Core.RepositoryBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework;
public class EfRepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
    where TEntity : class, IEntity
    where TContext : DbContext, new()
{
    public void Add(TEntity entity)
    {
        using TContext context = new();

        var addEntity = context.Entry(entity);

        addEntity.State = EntityState.Added;
        context.SaveChanges();
    }

    public async Task AddAsync(TEntity entity)
    {
        await using TContext context = new();
        var addEntity = context.Entry(entity);
        addEntity.State = EntityState.Modified;
        await context.SaveChangesAsync();
    }

    public void Delete(TEntity entity)
    {
        using TContext context = new();
        var deleteEntity = context.Entry(entity);
        deleteEntity.State = EntityState.Deleted;
        context.SaveChanges();
    }

    public TEntity? Get(Expression<Func<TEntity, bool>> expression, bool tracking = false)
    {
        using TContext context = new();
        if(tracking)
            return context.Set<TEntity>().FirstOrDefault(expression);
        return context.Set<TEntity>().AsNoTracking().FirstOrDefault(expression);
    }

    public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? expression, bool tracking = false)
    {
        using TContext context = new();

        if(tracking)
            return expression == null 
                ? context.Set<TEntity>().ToList() 
                : context.Set<TEntity>().Where(expression).ToList();

        return expression == null
                ? context.Set<TEntity>().AsNoTracking().ToList()
                : context.Set<TEntity>().AsNoTracking().Where(expression).ToList();
    }

    public TEntity? GetById(Guid id)
    {
        using TContext context = new();
        return context.Set<TEntity>().Find(id);
    }

    public void Update(TEntity entity)
    {
        using TContext context = new();
        var updateEntity = context.Entry(entity);
        updateEntity.State = EntityState.Modified;
        context.SaveChanges();
    }
}
