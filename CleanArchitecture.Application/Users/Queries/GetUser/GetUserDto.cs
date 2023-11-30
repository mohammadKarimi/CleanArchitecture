using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.Users.Queries.GetUser;

public record GetUserDto(Guid Id, Gender Gender, string Email);
