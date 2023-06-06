using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.Users.Queries.GetUser;

public class GetUserDto
{
    public Guid Id { get; set; }
    public Gender Gender { get; set; }
    public string Email { get; set; }
}