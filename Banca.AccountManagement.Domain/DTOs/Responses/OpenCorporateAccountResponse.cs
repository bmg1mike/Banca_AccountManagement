using Newtonsoft.Json;

namespace Banca.AccountManagement.Domain;

public class OpenCorporateAccountResponse
{
    [JsonProperty("nuban")]
    public string? Nuban { get; set; }

    [JsonProperty("customerId")]
    public string? CustomerId { get; set; }

    [JsonProperty("accountName")]
    public string? AccountName { get; set; }

    [JsonProperty("currency")]
    public string? Currency { get; set; }

    [JsonProperty("responseCode")]
    public string? ResponseCode { get; set; }

    [JsonProperty("responseText")]
    public string? ResponseText { get; set; }
}