using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Insurance
    {
        public decimal InsuranceId { get; set; }
        public decimal? BookingId { get; set; }
        public decimal PersonId { get; set; }
        public decimal? SupplierId { get; set; }
        public decimal? AgencyId { get; set; }
        public int InsuranceStatus { get; set; }
        public int InsuranceOrigin { get; set; }
        public string InsurancePwd { get; set; }
        public string InsuranceRefNo { get; set; }
        public string InsuranceSupplierRefNo { get; set; }
        public string InsuranceAgencyRefNo { get; set; }
        public int InsuranceAdults { get; set; }
        public int InsuranceChildren { get; set; }
        public int InsuranceInfants { get; set; }
        public string InsuranceChildAges { get; set; }
        public string InsurancePolicyType { get; set; }
        public decimal InsurancePolicyAmount { get; set; }
        public string InsurancePolicyCurrency { get; set; }
        public DateTime InsuranceFromDate { get; set; }
        public DateTime InsuranceToDate { get; set; }
        public string InsuranceImportantInfo { get; set; }
        public string InsuranceSpecialRequest { get; set; }
        public string InsuranceCurrency { get; set; }
        public decimal InsuranceTotalCost { get; set; }
        public decimal InsuranceTotalPaid { get; set; }
        public decimal InsuranceNetCost { get; set; }
        public DateTime? InsurancePaidDate { get; set; }
        public decimal? InsuranceAgencyCommision { get; set; }
        public DateTime? InsuranceAgencyPaidDate { get; set; }
        public DateTime? InsuranceSupplierPaidDate { get; set; }
        public string InsuranceNote { get; set; }
        public DateTime InsuranceAdded { get; set; }
        public string InsuranceCancellationPolicy { get; set; }

        public virtual Company Agency { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual Person Person { get; set; }
        public virtual Company Supplier { get; set; }
    }
}
