namespace CleanArchitecture.Application.Common.Interfaces;

public interface ISmsAdapter
{
    Task<int> SendAsync(string reciver, string text);
}
