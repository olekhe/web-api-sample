using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Accom
    {
        public Accom()
        {
            AccomDisc = new HashSet<AccomDisc>();
            AccomRoom = new HashSet<AccomRoom>();
            AccomSupp = new HashSet<AccomSupp>();
        }

        public decimal AccomId { get; set; }
        public decimal? BookingId { get; set; }
        public decimal PersonId { get; set; }
        public decimal? SupplierId { get; set; }
        public decimal? AgencyId { get; set; }
        public int AccomStatus { get; set; }
        public int AccomOrigin { get; set; }
        public string AccomPwd { get; set; }
        public string AccomRefNo { get; set; }
        public string AccomSupplierRefNo { get; set; }
        public string AccomAgencyRefNo { get; set; }
        public int AccomAdults { get; set; }
        public int AccomChildren { get; set; }
        public int AccomInfants { get; set; }
        public string AccomChildAges { get; set; }
        public decimal? HotelId { get; set; }
        public string AccomDestination { get; set; }
        public string AccomHotel { get; set; }
        public string AccomHotelAddress { get; set; }
        public string AccomHotelPhone { get; set; }
        public int AccomRooms { get; set; }
        public DateTime AccomArrival { get; set; }
        public DateTime AccomDeparture { get; set; }
        public int AccomDuration { get; set; }
        public string AccomImportantInfo { get; set; }
        public string AccomSpecialRequest { get; set; }
        public string AccomCurrency { get; set; }
        public decimal AccomTotalCost { get; set; }
        public decimal AccomTotalPaid { get; set; }
        public decimal AccomNetCost { get; set; }
        public DateTime? AccomPaidDate { get; set; }
        public decimal? AccomAgencyCommision { get; set; }
        public DateTime? AccomAgencyPaidDate { get; set; }
        public DateTime? AccomSupplierPaidDate { get; set; }
        public string AccomNote { get; set; }
        public DateTime AccomAdded { get; set; }
        public string AccomHotelCategory { get; set; }
        public string AccomCancellationPolicy { get; set; }

        public virtual Company Agency { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual Person Person { get; set; }
        public virtual Company Supplier { get; set; }
        public virtual ICollection<AccomDisc> AccomDisc { get; set; }
        public virtual ICollection<AccomRoom> AccomRoom { get; set; }
        public virtual ICollection<AccomSupp> AccomSupp { get; set; }
    }
}
