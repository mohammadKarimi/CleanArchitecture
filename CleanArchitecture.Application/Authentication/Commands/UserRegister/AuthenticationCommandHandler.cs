using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Authentication.Commands.UserRegister;

public class AuthenticationCommandHandler(IApplicationUnitOfWork unitOfWork)
    : IRequestHandler<UserRegisterCommand, Guid>
{
    private readonly IApplicationUnitOfWork _uow = unitOfWork;

    public async Task<Guid> Handle(UserRegisterCommand request, CancellationToken cancellationToken = default)
    {
        var model = new User
        {
            Email = request.Email,
            Password = request.Password,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Gender = request.Gender,
            UserName = request.UserName
        };
        _uow.Users.Add(model);
        await _uow.SaveChangesAsync(cancellationToken);
        return model.Id;
    }
}