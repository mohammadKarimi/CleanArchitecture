namespace CleanArchitecture.Application.Common.Interfaces;

public interface ISmsAdapter
{
    Task<ActionResult> SendAsync(string reciver, string text);
}
