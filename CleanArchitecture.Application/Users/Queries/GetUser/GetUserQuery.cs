namespace CleanArchitecture.Application.Users.Queries.GetUser;

public record GetUserQuery : IRequest<GetUserDto>
{
    public Guid Id { get; set; }
}