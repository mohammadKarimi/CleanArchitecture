using CleanArchitecture.Domain.Repositories;

namespace CleanArchitecture.Application.Common;

public interface IApplicationContext : IUnitOfWork
{
    public IUserRepository UserRepository { get; }
}
