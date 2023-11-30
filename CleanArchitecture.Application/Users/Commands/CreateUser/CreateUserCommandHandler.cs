using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler(IApplicationUnitOfWork applicationUnitOfWork)
    : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly IApplicationUnitOfWork _uow = applicationUnitOfWork;

    public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken = default)
    {
        var user = new User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email
        };
        _uow.Users.Add(user);
        await _uow.SaveChangesAsync(cancellationToken);
        return user.Id;
    }
}