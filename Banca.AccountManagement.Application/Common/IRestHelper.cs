using Banca.AccountManagement.Domain.Enums;

namespace Banca.AccountManagement.Application;

public interface IRestHelper
{
    Task<Result<T>> RestCall<T>(string url, object payload = null!, Dictionary<string, string> headers = null!, ApiType apiType = ApiType.Post);
}