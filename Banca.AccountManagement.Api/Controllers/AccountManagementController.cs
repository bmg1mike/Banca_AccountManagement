using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banca.AccountManagement.Application;
using Banca.AccountManagement.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Banca.AccountManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountManagementController : ControllerBase
    {
        private readonly IAccountManagementService service;

        public AccountManagementController(IAccountManagementService service)
        {
            this.service = service;
        }

        [HttpPost("OpenCorporateAccount")]
        public async Task<IActionResult> OpenCorporateAccount(AccountOpeningRequest request)
        {
            return Ok(await service.OpenCorporateAccount(request));
        }

        [HttpGet("GetAccountsByCustomerId/{CustomerId}")]
        [Authorize]
        public async Task<IActionResult> GetAccountsByCustomerId(string customerId)
        {
            return Ok(await service.GetCustomerAccountDetailsByCustomerIdAsync(customerId));
        }

        [HttpGet("GetCustomerIdByAccountNumber/{accountNumber}")]
        public async Task<IActionResult> GetCustomerIdByAccountNumber(string accountNumber)
        {
            return Ok(await service.GetCustomerIdByAccountNumber(accountNumber));
        }

    }
}