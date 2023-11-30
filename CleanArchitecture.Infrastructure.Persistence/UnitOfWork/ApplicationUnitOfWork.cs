using CleanArchitecture.Application.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Persistence.Context;

public partial class ApplicationUnitOfWork(ApplicationDbContext applicationDbContext)
    : IApplicationUnitOfWork
{
    private readonly ApplicationDbContext _context = applicationDbContext;

    public async Task<Result> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            await _context.SaveChangesAsync(cancellationToken);
            return Result.Success();
        }
        catch (DbUpdateConcurrencyException e)
        {
            //If you want to do something
            return Result.Failure(e.Message);
        }
        catch (DbUpdateException e)
        {
            return Result.Failure(e.Message);
        }
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
        GC.SuppressFinalize(this);
    }
}