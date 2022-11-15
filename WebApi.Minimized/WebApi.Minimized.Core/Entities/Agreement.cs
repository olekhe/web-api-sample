using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Agreement
    {
        public Agreement()
        {
            AgrLogin = new HashSet<AgrLogin>();
            AgrProxy = new HashSet<AgrProxy>();
        }

        public decimal AgreementId { get; set; }
        public decimal CompanyId { get; set; }
        public string AgreementTitle { get; set; }
        public string AgreementNumber { get; set; }
        public DateTime? AgreementDate { get; set; }
        public string AgreementNote { get; set; }
        public string AgreementCompany { get; set; }
        public string AgreementDirector { get; set; }
        public string AgreementLicense { get; set; }
        public string AgreementAddress { get; set; }
        public decimal? AgreementEdrpou { get; set; }
        public decimal? AgreementMfo { get; set; }
        public decimal? AgreementAccount { get; set; }
        public string AgreementBank { get; set; }
        public string AgreementTax { get; set; }
        public string AgreementTaxNumber { get; set; }
        public string AgreementStatute { get; set; }
        public string AgreementPhone { get; set; }
        public string AgreementFax { get; set; }
        public string AgreementEmail { get; set; }
        public string AgreementUrl { get; set; }
        public DateTime AgreementAdded { get; set; }
        public decimal? AgreementAddedById { get; set; }
        public DateTime? AgreementUpdated { get; set; }
        public decimal? AgreementUpdatedById { get; set; }
        public Guid AgreementGuid { get; set; }
        public string AgreementByDirector { get; set; }
        public string AgreementAddressReal { get; set; }
        public string AgreementIpaddress { get; set; }
        public bool AgreementArchived { get; set; }
        public string AgreementByDirectorTitle { get; set; }
        public DateTime? AgreementValidTill { get; set; }
        public int? AgreementType { get; set; }
        public int? AgreementStatus { get; set; }
        public string AgreementLoginUrl { get; set; }
        public string AgreementLoginExt { get; set; }
        public string AgreementLogin { get; set; }
        public string AgreementPwd { get; set; }
        public decimal? AgreementMfo2 { get; set; }
        public string AgreementAccount2 { get; set; }
        public string AgreementBank2 { get; set; }
        public string AgreementPhone2 { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<AgrLogin> AgrLogin { get; set; }
        public virtual ICollection<AgrProxy> AgrProxy { get; set; }
    }
}
