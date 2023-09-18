namespace CleanArchitecture.Application.Common.Interfaces;

public interface ISmsAdapter
{
    Task<ActionResult> SendAsync(string receiver, string text);
}
