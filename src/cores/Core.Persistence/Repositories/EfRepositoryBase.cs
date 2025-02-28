using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Core.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Persistence.Repositories;

public abstract class EfRepositoryBase<TEntity, TId, TContext>(TContext Context)
    : IAsyncRepository<TEntity, TId> where TEntity : Entity<TId> where TContext : DbContext
{
    public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        Context.Set<TEntity>().Entry(entity).State = EntityState.Added;
        await Context.SaveChangesAsync(cancellationToken: cancellationToken);
        return entity;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        entity.UpdatedTime = DateTime.Now;
        Context.Set<TEntity>().Entry(entity).State = EntityState.Modified;
        await Context.SaveChangesAsync(cancellationToken: cancellationToken);
        return entity;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        Context.Set<TEntity>().Entry(entity).State = EntityState.Deleted;
        await Context.SaveChangesAsync(cancellationToken: cancellationToken);
        return entity;
    }
    
    public async Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null,
        bool enableTracking = true, bool include = true,
        CancellationToken cancellationToken = default)
    {
        IQueryable<TEntity> query = Context.Set<TEntity>();
        if (filter is not null)
            query = query.Where(filter);
        if (enableTracking is false)
            query = query.AsNoTracking();
        if (include is false)
            query = query.IgnoreAutoIncludes();
        return await query.ToListAsync(cancellationToken);
    }

    public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> filter, bool enableTracking = true,
        bool include = true,
        CancellationToken cancellationToken = default)
    {
        IQueryable<TEntity> query = Context.Set<TEntity>();
        if (enableTracking is false)
            query = query.AsNoTracking();
        if (include is false)
            query = query.IgnoreAutoIncludes();
        return await query.FirstOrDefaultAsync(filter, cancellationToken);
    }

    public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? filter = null, bool enableTracking = true,
        CancellationToken cancellationToken = default)
    {
        IQueryable<TEntity> query = Context.Set<TEntity>();
        if (enableTracking is false)
            query = query.AsNoTracking();
        if (filter is not null)
            return await query.AnyAsync(filter, cancellationToken);
        return await query.AnyAsync(cancellationToken);
    }

    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public async Task<ICollection<TEntity>> AddRangeAsync(ICollection<TEntity> entities,
        CancellationToken cancellationToken = default)
    {
        await Context.Set<TEntity>().AddRangeAsync(entities, cancellationToken);
        await Context.SaveChangesAsync(cancellationToken);
        return entities;
    }
}