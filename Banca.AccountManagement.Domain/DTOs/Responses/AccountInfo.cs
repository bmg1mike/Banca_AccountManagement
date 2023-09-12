using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Banca.AccountManagement.Domain;

public class AccountInfo
{
    [JsonProperty("GetAccountFullInfo")]
    public GetAccountFullInfo? GetAccountFullInfo { get; set; }
}
public class BankAccountFullInfo
{
    [JsonProperty("NUBAN")]
    public string? NUBAN { get; set; }

    [JsonProperty("BRA_CODE")]
    public string? BRACODE { get; set; }

    [JsonProperty("DES_ENG")]
    public string? DESENG { get; set; }

    [JsonProperty("CUS_NUM")]
    public string? CUSNUM { get; set; }

    [JsonProperty("CUR_CODE")]
    public string? CURCODE { get; set; }

    [JsonProperty("LED_CODE")]
    public string? LEDCODE { get; set; }

    [JsonProperty("CUS_SHO_NAME")]
    public string? CUSSHONAME { get; set; }

    [JsonProperty("AccountGroup")]
    public string? AccountGroup { get; set; }

    [JsonProperty("CustomerStatus")]
    public string? CustomerStatus { get; set; }

    [JsonProperty("ADD_LINE1")]
    public string? ADDLINE1 { get; set; }

    [JsonProperty("ADD_LINE2")]
    public string? ADDLINE2 { get; set; }

    [JsonProperty("MOB_NUM")]
    public string? MOBNUM { get; set; }

    [JsonProperty("email")]
    public string? Email { get; set; }

    [JsonProperty("ACCT_NO")]
    public string? ACCTNO { get; set; }

    [JsonProperty("MAP_ACC_NO")]
    public string? MAPACCNO { get; set; }

    [JsonProperty("ACCT_TYPE")]
    public string? ACCTTYPE { get; set; }

    [JsonProperty("ISO_ACCT_TYPE")]
    public object? ISOACCTTYPE { get; set; }

    [JsonProperty("TEL_NUM")]
    public string? TELNUM { get; set; }

    [JsonProperty("DATE_OPEN")]
    public string? DATEOPEN { get; set; }

    [JsonProperty("STA_CODE")]
    public string? STACODE { get; set; }

    [JsonProperty("CLE_BAL")]
    public string? CLEBAL { get; set; }

    [JsonProperty("CRNT_BAL")]
    public string? CRNTBAL { get; set; }

    [JsonProperty("TOT_BLO_FUND")]
    public string? TOTBLOFUND { get; set; }

    [JsonProperty("INTRODUCER")]
    public string? INTRODUCER { get; set; }

    [JsonProperty("DATE_BAL_CHA")]
    public string? DATEBALCHA { get; set; }

    [JsonProperty("NAME_LINE1")]
    public string? NAMELINE1 { get; set; }

    [JsonProperty("NAME_LINE2")]
    public string? NAMELINE2 { get; set; }

    [JsonProperty("BVN")]
    public string? BVN { get; set; }

    [JsonProperty("REST_FLAG")]
    public string? RESTFLAG { get; set; }

    [JsonProperty("IsSMSSubscriber")]
    public string? IsSMSSubscriber { get; set; }

    [JsonProperty("Alt_Currency")]
    public string? AltCurrency { get; set; }

    [JsonProperty("Currency_Code")]
    public string? CurrencyCode { get; set; }

    [JsonProperty("T24_BRA_CODE")]
    public string? T24BRACODE { get; set; }

    [JsonProperty("T24_CUS_NUM")]
    public string? T24CUSNUM { get; set; }

    [JsonProperty("T24_CUR_CODE")]
    public string? T24CURCODE { get; set; }

    [JsonProperty("T24_LED_CODE")]
    public string? T24LEDCODE { get; set; }

    [JsonProperty("OnlineActualBalance")]
    public string? OnlineActualBalance { get; set; }

    [JsonProperty("OnlineClearedBalance")]
    public string? OnlineClearedBalance { get; set; }

    [JsonProperty("OpenActualBalance")]
    public string? OpenActualBalance { get; set; }

    [JsonProperty("OpenClearedBalance")]
    public string? OpenClearedBalance { get; set; }

    [JsonProperty("WorkingBalance")]
    public string? WorkingBalance { get; set; }

    [JsonProperty("CustomerStatusCode")]
    public string? CustomerStatusCode { get; set; }

    [JsonProperty("CustomerStatusDeecp")]
    public string? CustomerStatusDeecp { get; set; }

    [JsonProperty("LimitID")]
    public object? LimitID { get; set; }

    [JsonProperty("LimitAmt")]
    public object? LimitAmt { get; set; }

    [JsonProperty("MinimumBal")]
    public string? MinimumBal { get; set; }

    [JsonProperty("UsableBal")]
    public string? UsableBal { get; set; }

    [JsonProperty("AccountDescp")]
    public string? AccountDescp { get; set; }

    [JsonProperty("CourtesyTitle")]
    public object? CourtesyTitle { get; set; }

    [JsonProperty("AccountTitle")]
    public string? AccountTitle { get; set; }

    [JsonProperty("ManualRiskRating")]
    public object? ManualRiskRating { get; set; }

    [JsonProperty("CalculatedRiskRating")]
    public object? CalculatedRiskRating { get; set; }
}

public class GetAccountFullInfo
{
    [JsonProperty("BankAccountFullInfo")]
    public List<BankAccountFullInfo>? BankAccountFullInfo { get; set; }

    [JsonProperty("RestrictFlag")]
    public List<RestrictFlag>? RestrictFlag { get; set; }
}

public class RestrictFlag
{
    [JsonProperty("ResCode")]
    public string? ResCode { get; set; }

    [JsonProperty("ResDescp")]
    public string? ResDescp { get; set; }
}