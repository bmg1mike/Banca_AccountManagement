using Newtonsoft.Json;

namespace Banca.AccountManagement.Domain;

public class OpenCorporateAccountRequest
{
    [JsonProperty("userDetails")]
    public UserDetails? UserDetails { get; set; }

    [JsonProperty("accountCreationDetails")]
    public AccountCreationDetails? AccountCreationDetails { get; set; }
}

public class UserDetails
{
    [JsonProperty("bvn")]
    public string? Bvn { get; set; }

    [JsonProperty("dateOfBirth")]
    public DateTime DateOfBirth { get; set; }

    [JsonProperty("email")]
    public string? Email { get; set; }

    [JsonProperty("password")]
    public string? Password { get; set; }

    [JsonProperty("phoneNumber")]
    public string? PhoneNumber { get; set; }

    [JsonProperty("address")]
    public string? Address { get; set; }

    [JsonProperty("country")]
    public string? Country { get; set; }

    [JsonProperty("state")]
    public string? State { get; set; }

    [JsonProperty("accountNumber")]
    public string? AccountNumber { get; set; }

    [JsonProperty("initialAccountSelected")]
    public string? InitialAccountSelected { get; set; }

    [JsonProperty("progressLevel")]
    public string? ProgressLevel { get; set; }

    [JsonProperty("firstName")]
    public string? FirstName { get; set; }

    [JsonProperty("middleName")]
    public string? MiddleName { get; set; }

    [JsonProperty("lastName")]
    public string? LastName { get; set; }

    [JsonProperty("preferredName")]
    public string? PreferredName { get; set; }

    [JsonProperty("sector")]
    public string? Sector { get; set; }

    [JsonProperty("industry")]
    public string? Industry { get; set; }

    [JsonProperty("nationality")]
    public string? Nationality { get; set; }

    [JsonProperty("gender")]
    public string? Gender { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("sessionKey")]
    public string? SessionKey { get; set; }

    [JsonProperty("employmentStatus")]
    public string? EmploymentStatus { get; set; }

    [JsonProperty("employerName")]
    public string? EmployerName { get; set; }

    [JsonProperty("employmentAddress")]
    public string? EmploymentAddress { get; set; }

    [JsonProperty("addressTown")]
    public string? AddressTown { get; set; }

    [JsonProperty("addressState")]
    public string? AddressState { get; set; }

    [JsonProperty("addressLandmark")]
    public string? AddressLandmark { get; set; }

    [JsonProperty("userName")]
    public string? UserName { get; set; }

    [JsonProperty("bvN_Firstname")]
    public string? BvNFirstname { get; set; }

    [JsonProperty("bvN_Lastname")]
    public string? BvNLastname { get; set; }

    [JsonProperty("isDefaultPassword")]
    public bool IsDefaultPassword { get; set; }

    [JsonProperty("residence")]
    public string? Residence { get; set; }

    [JsonProperty("referralCode")]
    public string? ReferralCode { get; set; }

    [JsonProperty("clientID")]
    public string? ClientID { get; set; }

    [JsonProperty("nokAddress")]
    public string? NokAddress { get; set; }

    [JsonProperty("nokPhoneNumber")]
    public string? NokPhoneNumber { get; set; }

    [JsonProperty("nokRelationship")]
    public string? NokRelationship { get; set; }

    [JsonProperty("nokFullName")]
    public string? NokFullName { get; set; }

    [JsonProperty("mandateInstruction")]
    public string? MandateInstruction { get; set; }

    [JsonProperty("numberOfSignatories")]
    public string? NumberOfSignatories { get; set; }

    [JsonProperty("businessType")]
    public string? BusinessType { get; set; }

    [JsonProperty("tin")]
    public string? Tin { get; set; }

    [JsonProperty("signatoryAddress")]
    public string? SignatoryAddress { get; set; }

    [JsonProperty("signatoryPhoneNumber")]
    public string? SignatoryPhoneNumber { get; set; }

    [JsonProperty("cerpac")]
    public string? Cerpac { get; set; }

    [JsonProperty("dateOfIncorporation")]
    public DateTime DateOfIncorporation { get; set; }

    [JsonProperty("dao")]
    public string? Dao { get; set; }

    [JsonProperty("stateOfRegistration")]
    public string? StateOfRegistration { get; set; }

    [JsonProperty("requestRefId1")]
    public string? RequestRefId1 { get; set; }

    [JsonProperty("requestRefId2")]
    public string? RequestRefId2 { get; set; }

    [JsonProperty("countryOfBirth")]
    public string? CountryOfBirth { get; set; }

    [JsonProperty("otherNationality")]
    public string? OtherNationality { get; set; }

    [JsonProperty("taxId")]
    public string? TaxId { get; set; }
}

public class AccountCreationDetails
{
    [JsonProperty("rcNumber")]
    public string? RcNumber { get; set; }

    [JsonProperty("incorpDate")]
    public DateTime IncorpDate { get; set; }

    [JsonProperty("tin")]
    public string? Tin { get; set; }

    [JsonProperty("businessName")]
    public string? BusinessName { get; set; }

    [JsonProperty("branch")]
    public string? Branch { get; set; }

    [JsonProperty("emailAddress")]
    public string? EmailAddress { get; set; }

    [JsonProperty("productCode")]
    public string? ProductCode { get; set; }

    [JsonProperty("currency")]
    public string? Currency { get; set; }

    [JsonProperty("clientID")]
    public string? ClientID { get; set; }
}

