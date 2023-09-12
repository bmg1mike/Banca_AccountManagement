using System.Text;
using System.Text.Json;
using Banca.AccountManagement.Domain.Enums;
using Microsoft.Extensions.Logging;

namespace Banca.AccountManagement.Application;

public class RestHelper : IRestHelper
{
    private readonly IHttpClientFactory httpClient;
    private readonly ILogger<RestHelper> logger;

    public RestHelper(IHttpClientFactory httpClient, ILogger<RestHelper> logger)
    {
        this.httpClient = httpClient;
        this.logger = logger;
    }

    public async Task<Result<T>> RestCall<T>(string url,object payload = null!,Dictionary<string,string> headers = null!,ApiType apiType = ApiType.Post)
    {
        try
        {
            var client = httpClient.CreateClient("AccountManagement");
            var requestMessage = new HttpRequestMessage();
            requestMessage.RequestUri = new Uri(url);
            switch (apiType)
            {
                case ApiType.Get:
                    requestMessage.Method = HttpMethod.Get;
                    break;
                case ApiType.Post :
                    requestMessage.Method = HttpMethod.Post;
                    break;
                case ApiType.Put :
                    requestMessage.Method = HttpMethod.Put;
                    break;
                default:
                    requestMessage.Method = HttpMethod.Delete;
                    break;
            }

            if (headers is not null)
            {
                foreach (var item in headers)
                {
                    requestMessage.Headers.Add(item.Key, item.Value);
                }
            }

            if (payload is not null)
            {
                var serializePayload = JsonSerializer.Serialize(payload);
                requestMessage.Content = new StringContent(serializePayload, Encoding.UTF8, "application/json");
            }

            var response = await client.SendAsync(requestMessage);
            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return Result<T>.Success(JsonSerializer.Deserialize<T>(result));
            }

            logger.LogError(result);
            return Result<T>.Failure("The call failed");
            
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
            return Result<T>.Failure("A fatal error occurred");
        }
    }
}