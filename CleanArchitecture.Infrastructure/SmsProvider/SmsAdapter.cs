using CleanArchitecture.Application.Common;
using CleanArchitecture.Application.Common.Interfaces;
using Polly;
using Polly.CircuitBreaker;
using Polly.Fallback;
using Polly.Retry;

namespace CleanArchitecture.Infrastructure.SmsProvider;

internal class SmsAdapter : ISmsAdapter
{
    private readonly AsyncRetryPolicy<ActionResult> _retryPolicy;
    private readonly AsyncFallbackPolicy<ActionResult> _fallbackPolicy;
    private static AsyncCircuitBreakerPolicy _circuitBreakerPolicy;

    private readonly HttpClient _httpClient;
    private const string url = "https://google.com/";

    public SmsAdapter(IHttpClientFactory httpClientFactory)
    {

        _circuitBreakerPolicy = Policy.Handle<Exception>()
                                .CircuitBreakerAsync(2, TimeSpan.FromMinutes(1));


        _retryPolicy = Policy<ActionResult>.Handle<Exception>().RetryAsync(2);

        _fallbackPolicy = Policy<ActionResult>.Handle<Exception>().FallbackAsync
            (ActionResult.Failure("Error on Sending message"));

        _httpClient = httpClientFactory.CreateClient();
    }

    public async Task<ActionResult> SendAsync(string reciver, string text)
    {
        var result = await _circuitBreakerPolicy.ExecuteAsync(async () =>
       {
           var content = new FormUrlEncodedContent(new[]
                       {
                new KeyValuePair<string, string>("reciver",reciver),
                new KeyValuePair<string, string>("text",text)
           });
           return await _httpClient.PostAsync(url, content);
       });
        if (result.IsSuccessStatusCode)
            return new();
        else return new("Error on Sending message");
    }
}