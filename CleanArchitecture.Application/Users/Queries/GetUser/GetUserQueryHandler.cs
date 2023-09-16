namespace CleanArchitecture.Application.Users.Queries.GetUser;

public class GetUserQueryHandler : IRequestHandler<GetUserQuery, GetUserDto>
{
    private readonly IApplicationUnitOfWork _uow;

    public GetUserQueryHandler(IApplicationUnitOfWork applicationUnitOfWork)
        => _uow = applicationUnitOfWork;

    public async Task<GetUserDto> Handle(GetUserQuery request, CancellationToken cancellationToken = default)
    {
        var result = await _uow.Users
                                   .Select(x => new GetUserDto
                                   {
                                       Email = x.Email,
                                       Gender = x.Gender,
                                       Id = x.Id
                                   })
                                   .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        return result;
    }
}