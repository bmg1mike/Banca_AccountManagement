using Banca.AccountManagement.Domain;
using Banca.AccountManagement.Domain.DTOs.Requests;
using Banca.AccountManagement.Domain.DTOs.Responses;
using Banca.AccountManagement.Domain.Enums;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
namespace Banca.AccountManagement.Application;

public class AccountManagementService : IAccountManagementService
{
    private readonly ILogger<AccountManagementService> logger;
    private readonly IEncryptionService encryptionService;
    private readonly IRestHelper restHelper;
    private readonly IConfiguration config;

    public AccountManagementService(ILogger<AccountManagementService> logger, IEncryptionService encryptionService, IRestHelper restHelper, IConfiguration config)
    {
        this.logger = logger;
        this.encryptionService = encryptionService;
        this.restHelper = restHelper;
        this.config = config;
    }

    public async Task<Result<OpenCorporateAccountResponse>> OpenCorporateAccount(AccountOpeningRequest request)
    {
        try
        {
            var aesSecretKey = config["AesSecretKey"];
            var iv = config["AesInitializationVector"];
            var url = config["AccountEndpoints:corporate_account_opening_url"];

            var bvnDetails = await GetBvnDetails(request.DateOfBirth, request.Bvn);

            if (bvnDetails == null)
            {
                return Result<OpenCorporateAccountResponse>.Failure("Bvn request failed");
            }

            var accountRequest = new OpenCorporateAccountRequest
            {
                BusinessName = request.BusinessName,
                Bvn = request.Bvn,
                CountryOfBirth = request.CountryOfBirth,
                Currency = "NGN",
                DateOfBirth = request.DateOfBirth,
                FirstName = bvnDetails.FirstName,
                EmailAddress = request.EmailAddress,
                IncorpDate = request.DateOfIncorporation,
                CorporateAddress = request.SignatoryAddress,
                Email = request.EmailAddress,
                Gender = bvnDetails.Gender,
                Documents = request.Documents,
                Industry = request.Industry,
                Tin = request.Tin,
                TaxId = request.TaxId,
                ClientID = "2",
                Lga = bvnDetails.LgaOfResidence,
                CountryTaxRes = "NG",
                CityTown = bvnDetails.LgaOfResidence,
                Title = bvnDetails.Title.ToUpper(),
                BranchCode = request.Branch ?? "NG0020002",
                IdentificationType = request.IdentificationType,
                MiddleName = bvnDetails.MiddleName,
                Nationality = bvnDetails.Nationality,
                Phone = request.PhoneNumber,
                

                // AccountCreationDetails = new AccountCreationDetails
                // {
                //     BusinessName = request.BusinessName,
                //     RcNumber = request.RcNumber,
                //     EmailAddress = request.EmailAddress,
                //     IncorpDate = request.DateOfIncorporation,
                //     Branch = request.Branch ?? "NG0020002",
                //     Currency = "NGN",
                //     Tin = request.Tin,
                //     ClientID = "2",
                //     ProductCode = "CLASSIC.CUR"
                // },
                // UserDetails = new UserDetails
                // {
                //     Address = bvnDetails.ResidentialAddress,
                //     AddressState = bvnDetails.StateOfResidence,
                //     BusinessType = request.BusinessType,
                //     Bvn = request.Bvn,
                //     BvNFirstname = bvnDetails.FirstName,
                //     BvNLastname = bvnDetails.LastName,
                //     AddressTown = bvnDetails.LgaOfResidence,
                //     Country = "NG",
                //     CountryOfBirth = request.CountryOfBirth,
                //     FirstName = bvnDetails.FirstName,
                //     DateOfBirth = request.DateOfBirth,
                //     DateOfIncorporation = request.DateOfIncorporation,
                //     Email = request.EmailAddress,
                //     EmployerName = request.EmployerName,
                //     EmploymentAddress = request.EmployerAddress,
                //     LastName = bvnDetails.LastName,
                //     ClientID = "2",
                //     NokFullName = request.NextOfKinFullName,
                //     NokAddress = request.NextOfKinAddress,
                //     NokRelationship = request.NextOfKinRelationship,
                //     NokPhoneNumber = request.NextOfKinPhoneNumber,
                //     Gender = bvnDetails.Gender,
                //     PreferredName = bvnDetails.FirstName,
                //     Nationality = bvnDetails.Nationality,
                //     EmploymentStatus = request.EmploymentStatus,
                //     NumberOfSignatories = request.NumberOfSignatories,
                //     SignatoryAddress = request.SignatoryAddress,
                //     SignatoryPhoneNumber = request.SignatoryPhoneNumber,
                //     StateOfRegistration = request.StateOfRegistration,
                //     TaxId = request.TaxId,
                //     PhoneNumber = request.PhoneNumber,
                //     Residence = bvnDetails.StateOfResidence,
                //     ProgressLevel = "string",
                //     Sector = request.Sector,
                //     Industry = request.Industry,
                //     Title = bvnDetails.Title.ToUpper()
                // }
            };

            var encryptedPayload = encryptionService.EncryptAes(JsonConvert.SerializeObject(accountRequest), aesSecretKey, iv);
            var headers = new Dictionary<string, string>
            {
                { "ApiKey", "wrqewtreyrutyterewrtretre" }
            };

            var response = await restHelper.RestCall<string>(url, encryptedPayload, headers);

            if (response.IsSuccess == false)
            {
                return Result<OpenCorporateAccountResponse>.Failure("unable to open your account, please try again later");
            }

            var decryptedResponse = encryptionService.DecryptAes(response.Value, aesSecretKey, iv);

            var accountOpeningResponse = JsonConvert.DeserializeObject<OpenCorporateAccountResponse>(decryptedResponse);

            return Result<OpenCorporateAccountResponse>.Success(accountOpeningResponse);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
            return Result<OpenCorporateAccountResponse>.Failure(ex.Message);
        }
    }

    public async Task<Result<List<AccountDetails>>> GetCustomerAccountDetailsByCustomerIdAsync(string customerId)
    {
        var accountDetails = new List<AccountDetails>();
        try
        {
            var url = $"http://172.18.41.77:1880/restgateway/services/EacbsEnquiry/GetCustomerInfo/{customerId}";
            var response = await restHelper.RestCall<AccountInfo>(url, ApiType.Get);

            if (response.IsSuccess)
            {
                foreach (var item in response.Value.GetAccountFullInfo.BankAccountFullInfo)
                {
                    accountDetails.Add(new AccountDetails
                    {
                        AccountNumber = item.NUBAN,
                        AccountType = item.ACCTTYPE,
                        Balance = item.UsableBal
                    });
                }
                return Result<List<AccountDetails>>.Success(accountDetails);

            }
            return Result<List<AccountDetails>>.Failure("There is a problem getting the account details");
        }
        catch (Exception ex)
        {

            logger.LogError(ex, ex.Message);
            return Result<List<AccountDetails>>.Failure("There is a problem getting the account details..... Please try again later");
        }
    }

    public async Task<Result<GetAccountFullInfoResponse>> GetCustomerIdByAccountNumber(string accountNumber)
    {
        try
        {
            var url = "http://10.0.41.102:2342/api/User/FioranoGetAccountFullInfo";
            var aesSecretKey = config["AesSecretKey"];
            var iv = config["AesInitializationVector"];
            var body = encryptionService.EncryptAes(accountNumber, aesSecretKey, iv);
            var headers = new Dictionary<string, string>
            {
                { "ApiKey", "wrqewtreyrutyterewrtretre" }
            };
            var response = await restHelper.RestCall<string>(url, body, headers);

            if (response.IsSuccess)
            {
                var bvnDetails = encryptionService.DecryptAes(response.Value, aesSecretKey, iv);
                var result = JsonConvert.DeserializeObject<GetAccountFullInfoResponse>(bvnDetails);
                if (result.ResponseCode == "00")
                {
                    return Result<GetAccountFullInfoResponse>.Success(result);
                }

                return Result<GetAccountFullInfoResponse>.Failure(result.ResponseDescription);
            }

            return Result<GetAccountFullInfoResponse>.Failure("There was a problem, Please try again later");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
            return Result<GetAccountFullInfoResponse>.Failure("There was an issue");
        }
    }

    private async Task<BVNResponseModel> GetBvnDetails(DateTime dateOfBirth, string bvn)
    {
        try
        {
            var bvnUrl = $"{config["AccountEndpoints:Bvn_url"]}";
            var request = new BvnVerificationRequest
            {
                BVN = bvn,
                DateOfBirth = dateOfBirth
            };
            var payload = JsonConvert.SerializeObject(request);
            var aesSecretKey = config["AesSecretKey"];
            var iv = config["AesInitializationVector"];
            var encryptedPayload = encryptionService.EncryptAes(payload, aesSecretKey, iv);
            var headers = new Dictionary<string, string>
            {
                { "ApiKey", "wrqewtreyrutyterewrtretre" }
            };
            var bvnDetailsResponse = await restHelper.RestCall<string>(bvnUrl, encryptedPayload, headers);
            if (bvnDetailsResponse.IsSuccess == true)
            {
                var bvnDetails = encryptionService.DecryptAes(bvnDetailsResponse.Value, aesSecretKey, iv);
                var response = JsonConvert.DeserializeObject<BVNResponseModel>(bvnDetails);
                return response;
            }

            logger.LogInformation(bvnDetailsResponse.ResponseDescription);
            return null;

        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
            return null;
        }
    }
}