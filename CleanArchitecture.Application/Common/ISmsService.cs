namespace CleanArchitecture.Application.Common;

public interface ISmsAdapter
{
    Task<int> SendAsync(string reciver, string text);
}
