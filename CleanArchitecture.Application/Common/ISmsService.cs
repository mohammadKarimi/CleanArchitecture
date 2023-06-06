namespace CleanArchitecture.Application.Common;

public interface ISmsService
{
    Task<int> SendAsync(string reciver, string text);
}
