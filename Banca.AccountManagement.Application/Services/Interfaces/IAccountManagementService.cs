using Banca.AccountManagement.Domain;

namespace Banca.AccountManagement.Application;

public interface IAccountManagementService
{
    Task<Result<OpenCorporateAccountResponse>> OpenCorporateAccount(AccountOpeningRequest request);
    Task<Result<List<AccountDetails>>> GetCustomerAccountDetailsByCustomerIdAsync(string customerId);
    Task<Result<GetAccountFullInfoResponse>> GetCustomerIdByAccountNumber(string accountNumber);
}