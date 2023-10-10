using Newtonsoft.Json;

namespace Banca.AccountManagement.Domain;

public class OpenCorporateAccountRequest
{
    [JsonProperty("isRestriction")]
        public bool IsRestriction { get; set; }

        [JsonProperty("dateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [JsonProperty("statusJobTitle")]
        public string? StatusJobTitle { get; set; }

        [JsonProperty("nickName")]
        public string? NickName { get; set; }

        [JsonProperty("corpLegalForm")]
        public string? CorpLegalForm { get; set; }

        [JsonProperty("isDirector")]
        public string? IsDirector { get; set; }

        [JsonProperty("urlMandate")]
        public string? UrlMandate { get; set; }

        [JsonProperty("urlSignature")]
        public string? UrlSignature { get; set; }

        [JsonProperty("otherName")]
        public string? OtherName { get; set; }

        [JsonProperty("corporateAddress")]
        public string? CorporateAddress { get; set; }

        [JsonProperty("branchName")]
        public string? BranchName { get; set; }

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

        [JsonProperty("firstName")]
        public string? FirstName { get; set; }

        [JsonProperty("surName")]
        public string? SurName { get; set; }

        [JsonProperty("middleName")]
        public string? MiddleName { get; set; }

        [JsonProperty("street")]
        public string? Street { get; set; }

        [JsonProperty("sector")]
        public string? Sector { get; set; }

        [JsonProperty("industry")]
        public string? Industry { get; set; }

        [JsonProperty("nationality")]
        public string? Nationality { get; set; }

        [JsonProperty("bvn")]
        public string? Bvn { get; set; }

        [JsonProperty("gender")]
        public string? Gender { get; set; }

        [JsonProperty("dob")]
        public string? Dob { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }

        [JsonProperty("passportPhoto")]
        public string? PassportPhoto { get; set; }

        [JsonProperty("validIdType")]
        public string? ValidIdType { get; set; }

        [JsonProperty("validIdNumber")]
        public string? ValidIdNumber { get; set; }

        [JsonProperty("signature")]
        public string? Signature { get; set; }

        [JsonProperty("validId")]
        public string? ValidId { get; set; }

        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("jointAccountTransferLimit")]
        public string? JointAccountTransferLimit { get; set; }

        [JsonProperty("sqNo")]
        public int SqNo { get; set; }

        [JsonProperty("accountLinkCode")]
        public string? AccountLinkCode { get; set; }

        [JsonProperty("residence")]
        public string? Residence { get; set; }

        [JsonProperty("stateResidence")]
        public string? StateResidence { get; set; }

        [JsonProperty("appId")]
        public string? AppId { get; set; }

        [JsonProperty("shortTitle")]
        public string? ShortTitle { get; set; }

        [JsonProperty("scumlNum")]
        public string? ScumlNum { get; set; }

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

        [JsonProperty("dao")]
        public string? Dao { get; set; }

        [JsonProperty("sms")]
        public string? Sms { get; set; }

        [JsonProperty("branchCode")]
        public string? BranchCode { get; set; }

        [JsonProperty("internalRef")]
        public string? InternalRef { get; set; }

        [JsonProperty("productName")]
        public string? ProductName { get; set; }

        [JsonProperty("refereeAccountNumber1")]
        public string? RefereeAccountNumber1 { get; set; }

        [JsonProperty("refereeAccountNumber2")]
        public string? RefereeAccountNumber2 { get; set; }

        [JsonProperty("refereeBank1")]
        public string? RefereeBank1 { get; set; }

        [JsonProperty("refereeBank2")]
        public string? RefereeBank2 { get; set; }

        [JsonProperty("source")]
        public string? Source { get; set; }

        [JsonProperty("existingAccount")]
        public string? ExistingAccount { get; set; }

        [JsonProperty("internalReference")]
        public string? InternalReference { get; set; }

        [JsonProperty("chequeReference")]
        public string? ChequeReference { get; set; }

        [JsonProperty("iSsignatory")]
        public string? ISsignatory { get; set; }

        [JsonProperty("mandateAuth")]
        public string? MandateAuth { get; set; }

        [JsonProperty("classOfSig")]
        public string? ClassOfSig { get; set; }

        [JsonProperty("mandateInstruction")]
        public string? MandateInstruction { get; set; }

        [JsonProperty("identificationType")]
        public string? IdentificationType { get; set; }

        [JsonProperty("idNo")]
        public string? IdNo { get; set; }

        [JsonProperty("passportPic")]
        public string? PassportPic { get; set; }

        [JsonProperty("mandate")]
        public string? Mandate { get; set; }

        [JsonProperty("urlPhoto")]
        public string? UrlPhoto { get; set; }

        [JsonProperty("idName")]
        public string? IdName { get; set; }

        [JsonProperty("urlid")]
        public string? Urlid { get; set; }

        [JsonProperty("placeOfBirth")]
        public string? PlaceOfBirth { get; set; }

        [JsonProperty("motherMadienName")]
        public string? MotherMadienName { get; set; }

        [JsonProperty("religion")]
        public string? Religion { get; set; }

        [JsonProperty("stateOfOrigin")]
        public string? StateOfOrigin { get; set; }

        [JsonProperty("lga")]
        public string? Lga { get; set; }

        [JsonProperty("occupation")]
        public string? Occupation { get; set; }

        [JsonProperty("natureOfControl")]
        public string? NatureOfControl { get; set; }

        [JsonProperty("countryTaxRes")]
        public string? CountryTaxRes { get; set; }

        [JsonProperty("nearestBusstop")]
        public string? NearestBusstop { get; set; }

        [JsonProperty("city_Town")]
        public string? CityTown { get; set; }

        [JsonProperty("documents")]
        public List<Document> Documents { get; set; }
  
}

public class Document
    {
        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("documentName")]
        public string? DocumentName { get; set; }

        [JsonProperty("docURL")]
        public string? DocURL { get; set; }

        [JsonProperty("documentCategory")]
        public string? DocumentCategory { get; set; }

        [JsonProperty("documentTagName")]
        public string? DocumentTagName { get; set; }
    }

