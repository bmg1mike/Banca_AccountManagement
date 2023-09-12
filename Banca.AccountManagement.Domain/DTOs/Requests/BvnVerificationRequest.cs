using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banca.AccountManagement.Domain.DTOs.Requests
{
    public class BvnVerificationRequest
    {
        public string? BVN { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}