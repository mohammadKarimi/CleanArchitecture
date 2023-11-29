using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.Authentication.Commands.UserRegister;

public record UserRegisterCommand(
     string FirstName,
     string LastName,
     string Email,
     string UserName,
     string Password,
     Gender Gender
) : IRequest<Guid>;