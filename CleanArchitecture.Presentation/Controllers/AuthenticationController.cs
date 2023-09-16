using CleanArchitecture.Application.Authentication.Commands.UserRegister;
using CleanArchitecture.Application.Authentication.Queries.Login;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers;

public class AuthenticationController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<Guid>> Register([FromBody] UserRegisterCommand userRegisterCommand,
        CancellationToken cancellationToken  = default)
       => await Mediator.Send(userRegisterCommand);

    [HttpPost]
    public async Task<ActionResult<UserDto>> Login([FromBody] LoginQuery loginQuery,
        CancellationToken cancellationToken  = default)
       => await Mediator.Send(loginQuery);
}
