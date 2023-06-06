using CleanArchitecture.Application.Common.Interfaces;

namespace CleanArchitecture.Infrastructure.SmsProvider;

internal class SmsAdapter : ISmsAdapter
{
    public async Task<int> SendAsync(string reciver, string text)
    {
        await Task.CompletedTask;
        return 1;
    }
}