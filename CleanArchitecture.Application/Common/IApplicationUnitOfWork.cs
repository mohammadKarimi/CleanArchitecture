using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Common;

public interface IUnitOfWork : IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Save all entities in to database.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task<SaveChangesResult> SaveChangesAsync(CancellationToken cancellationToken = default);
}

public interface IApplicationUnitOfWork : IUnitOfWork
{
    public DbSet<User> Users { get; }
}
