using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.Authentication.Commands.UserRegister;

public record UserRegisterCommand : IRequest<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public Gender Gender { get; set; }
}