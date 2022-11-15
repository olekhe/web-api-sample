using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class CarHire
    {
        public decimal CarHireId { get; set; }
        public decimal? BookingId { get; set; }
        public decimal PersonId { get; set; }
        public decimal? SupplierId { get; set; }
        public decimal? AgencyId { get; set; }
        public int CarHireStatus { get; set; }
        public int CarHireOrigin { get; set; }
        public string CarHirePwd { get; set; }
        public string CarHireRefNo { get; set; }
        public string CarHireSupplierRefNo { get; set; }
        public string CarHireAgencyRefNo { get; set; }
        public int CarHireAdults { get; set; }
        public int CarHireChildren { get; set; }
        public int CarHireInfants { get; set; }
        public string CarHireChildAges { get; set; }
        public string CarHireCarType { get; set; }
        public string CarHirePickUpLocation { get; set; }
        public DateTime CarHirePickUpDate { get; set; }
        public string CarHirePickUpTime { get; set; }
        public string CarHireDropOffLocation { get; set; }
        public DateTime CarHireDropOffDate { get; set; }
        public string CarHireDropOffTime { get; set; }
        public string CarHireImportantInfo { get; set; }
        public string CarHireSpecialRequest { get; set; }
        public string CarHireCurrency { get; set; }
        public decimal CarHireTotalCost { get; set; }
        public decimal CarHireTotalPaid { get; set; }
        public decimal CarHireNetCost { get; set; }
        public DateTime? CarHirePaidDate { get; set; }
        public decimal? CarHireAgencyCommision { get; set; }
        public DateTime? CarHireAgencyPaidDate { get; set; }
        public DateTime? CarHireSupplierPaidDate { get; set; }
        public string CarHireNote { get; set; }
        public DateTime CarHireAdded { get; set; }
        public string CarHireCancellationPolicy { get; set; }

        public virtual Company Agency { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual Person Person { get; set; }
        public virtual Company Supplier { get; set; }
    }
}
