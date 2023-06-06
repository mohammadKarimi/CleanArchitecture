using CleanArchitecture.Application.Users.Command;
using FluentValidation;

namespace CleanArchitecture.Application.Users.Commands;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(u => u.FirstName)
               .NotEmpty().WithMessage("this field is required")
               .MaximumLength(50).WithMessage("first name must be less than 50");

        RuleFor(u => u.LastName)
               .NotEmpty().WithMessage("this field is required")
               .MaximumLength(50).WithMessage("last name must be less than 50");
    }
}