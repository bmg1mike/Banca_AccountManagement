using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banca.AccountManagement.Domain.DTOs.Responses
{
    public class BVNResponseModel
    {
        public string? ResponseCode { get; set; }
        public string? ResponseDesc { get; set; }
        public string? BVN { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? RegistrationDate { get; set; }
        public string? EnrollmentBank { get; set; }
        public string? EnrollmentBranch { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? PhoneNumber2 { get; set; }
        public string? LevelOfAccount { get; set; }
        public string? LgaOfOrigin { get; set; }
        public string? LgaOfResidence { get; set; }
        public string? MaritalStatus { get; set; }
        public string? NIN { get; set; }
        public string? NameOnCard { get; set; }
        public string? Nationality { get; set; }
        public string? ResidentialAddress { get; set; }
        public string? StateOfOrigin { get; set; }
        public string? StateOfResidence { get; set; }
        public string? Title { get; set; }
        public string? WatchListed { get; set; }
        public string? Base64Image { get; set; }
    }
}