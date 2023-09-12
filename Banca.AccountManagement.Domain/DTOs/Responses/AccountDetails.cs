using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banca.AccountManagement.Domain;

public class AccountDetails
{
    public string? AccountNumber { get; set; }
    public string? AccountType { get; set; }
    public string?  Balance { get; set; }
}