using CleanArchitecture.Application.Common;
using CleanArchitecture.Application.Users.Command;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Users.Commands;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly IApplicationContext _context;
    public CreateUserCommandHandler(IApplicationContext applicationContext)
        => _context = applicationContext;

    public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email
        };
        await _context.UserRepository.AddAsync(user);
        await _context.SaveChangesAsync(cancellationToken);
        return user.Id;
    }
}