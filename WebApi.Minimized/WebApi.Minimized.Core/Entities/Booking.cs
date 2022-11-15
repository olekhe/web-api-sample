using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Booking
    {
        public Booking()
        {
            Accom = new HashSet<Accom>();
            CarHire = new HashSet<CarHire>();
            Flight = new HashSet<Flight>();
            Insurance = new HashSet<Insurance>();
            Transfer = new HashSet<Transfer>();
        }

        public decimal BookingId { get; set; }
        public decimal PersonId { get; set; }
        public int BookingStatus { get; set; }
        public int BookingOrigin { get; set; }
        public string BookingPwd { get; set; }
        public string BookingRefNo { get; set; }
        public int BookingAdults { get; set; }
        public int BookingChildren { get; set; }
        public int BookingInfants { get; set; }
        public string BookingTitle { get; set; }
        public string BookingCurrency { get; set; }
        public decimal BookingTotalCost { get; set; }
        public decimal BookingTotalPaid { get; set; }
        public decimal BookingNetCost { get; set; }
        public DateTime? BookingPaidDate { get; set; }
        public string BookingNote { get; set; }
        public DateTime BookingAdded { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<Accom> Accom { get; set; }
        public virtual ICollection<CarHire> CarHire { get; set; }
        public virtual ICollection<Flight> Flight { get; set; }
        public virtual ICollection<Insurance> Insurance { get; set; }
        public virtual ICollection<Transfer> Transfer { get; set; }
    }
}
