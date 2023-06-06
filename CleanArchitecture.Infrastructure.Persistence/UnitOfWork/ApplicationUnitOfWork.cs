using CleanArchitecture.Application.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Persistence.Context
{
    public partial class ApplicationUnitOfWork : IApplicationUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public ApplicationUnitOfWork(ApplicationDbContext applicationDbContext)
           => _context = applicationDbContext;

        public async Task<SaveChangesResult> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                await _context.SaveChangesAsync(cancellationToken);
                return SaveChangesResult.Success();
            }
            catch (DbUpdateConcurrencyException e)
            {
                return SaveChangesResult.Failure(SaveChangesResultType.UpdateConcurrencyException, e.Message);
            }
            catch (DbUpdateException e)
            {
                return SaveChangesResult.Failure(SaveChangesResultType.UpdateException, e.Message);
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
}