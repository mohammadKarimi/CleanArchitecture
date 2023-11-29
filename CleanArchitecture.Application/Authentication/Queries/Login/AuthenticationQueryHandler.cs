namespace CleanArchitecture.Application.Authentication.Queries.Login;

public class AuthenticationQueryHandler(IApplicationUnitOfWork unitOfWork)
    : IRequestHandler<LoginQuery, UserDto>
{
    private readonly IApplicationUnitOfWork _uow = unitOfWork;

    public async Task<UserDto> Handle(LoginQuery request,
                                      CancellationToken cancellationToken = default)
    {
        var user = await _uow.Users.Where(x => x.UserName == request.Username
                                             && x.Password == request.Password)
                                  .Select(x => new UserDto(x.Email, x.FirstName, x.LastName))
                                  .FirstOrDefaultAsync(cancellationToken);
        return user ?? null;
    }
}

