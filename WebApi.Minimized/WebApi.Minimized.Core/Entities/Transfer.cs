using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Transfer
    {
        public decimal TransferId { get; set; }
        public decimal? BookingId { get; set; }
        public decimal PersonId { get; set; }
        public decimal? SupplierId { get; set; }
        public decimal? AgencyId { get; set; }
        public int TransferStatus { get; set; }
        public int TransferOrigin { get; set; }
        public string TransferPwd { get; set; }
        public string TransferRefNo { get; set; }
        public string TransferSupplierRefNo { get; set; }
        public string TransferAgencyRefNo { get; set; }
        public int TransferAdults { get; set; }
        public int TransferChildren { get; set; }
        public int TransferInfants { get; set; }
        public string TransferChildAges { get; set; }
        public string TransferAirport { get; set; }
        public string TransferAirportCode { get; set; }
        public string TransferHotel { get; set; }
        public string TransferHotelAddress { get; set; }
        public string TransferCarType { get; set; }
        public DateTime? TransferDepDate { get; set; }
        public string TransferDepTime { get; set; }
        public DateTime? TransferArrDate { get; set; }
        public string TransferArrTime { get; set; }
        public DateTime? TransferRetDepDate { get; set; }
        public string TransferRetDepTime { get; set; }
        public DateTime? TransferRetArrDate { get; set; }
        public string TransferRetArrTime { get; set; }
        public string TransferImportantInfo { get; set; }
        public string TransferSpecialRequest { get; set; }
        public string TransferCurrency { get; set; }
        public decimal TransferTotalCost { get; set; }
        public decimal TransferTotalPaid { get; set; }
        public decimal TransferNetCost { get; set; }
        public DateTime? TransferPaidDate { get; set; }
        public decimal? TransferAgencyCommision { get; set; }
        public DateTime? TransferAgencyPaidDate { get; set; }
        public DateTime? TransferSupplierPaidDate { get; set; }
        public string TransferNote { get; set; }
        public DateTime TransferAdded { get; set; }
        public string TransferCancellationPolicy { get; set; }

        public virtual Company Agency { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual Person Person { get; set; }
        public virtual Company Supplier { get; set; }
    }
}
