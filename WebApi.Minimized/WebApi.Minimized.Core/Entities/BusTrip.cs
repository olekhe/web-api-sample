using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class BusTrip
    {
        public BusTrip()
        {
            BusTripSeat = new HashSet<BusTripSeat>();
            PkgDate = new HashSet<PkgDate>();
        }

        public decimal BusTripId { get; set; }
        public decimal BusId { get; set; }
        public decimal BusRouteId { get; set; }
        public DateTime BusTripDate { get; set; }
        public bool BusTripEnabled { get; set; }
        public bool BusTriptArchived { get; set; }
        public string BusTripNote { get; set; }
        public DateTime? BusTripUpdated { get; set; }
        public DateTime BusTripAdded { get; set; }
        public bool BusTripArchived { get; set; }

        public virtual Bus Bus { get; set; }
        public virtual BusRoute BusRoute { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeat { get; set; }
        public virtual ICollection<PkgDate> PkgDate { get; set; }
    }
}
