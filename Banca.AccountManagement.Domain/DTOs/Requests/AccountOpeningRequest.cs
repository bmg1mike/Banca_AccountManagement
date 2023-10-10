
namespace Banca.AccountManagement.Domain;

public class AccountOpeningRequest
{
    public string? Bvn { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? BusinessName { get; set; }
    public DateTime DateOfIncorporation { get; set; }
    public string? EmailAddress { get; set; }
    public string? RcNumber { get; set; }
    public string? Branch { get; set; }
    public string? Tin { get; set; }
    public string? BusinessType { get; set; }
    public string? CountryOfBirth { get; set; }
    public string? EmployerName { get; set; }
    public string? EmployerAddress { get; set; }
    public string? NextOfKinFullName { get; set; }
    public string? NextOfKinAddress { get; set; }
    public string? NextOfKinRelationship { get; set; }
    public string? NextOfKinPhoneNumber { get; set; }
    public string? EmploymentStatus { get; set; }
    public string? NumberOfSignatories { get; set; }
    public string? SignatoryAddress { get; set; }
    public string? SignatoryPhoneNumber { get; set; }
    public string? StateOfRegistration { get; set; }
    public string? TaxId { get; set; }
    public string? Sector { get; set; }
    public string? Industry { get; set; }
    public List<Document> Documents { get; set; }
    public string IdentificationType { get; set; }
}