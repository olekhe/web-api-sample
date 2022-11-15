using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Bus
    {
        public Bus()
        {
            BusSeat = new HashSet<BusSeat>();
            BusTrip = new HashSet<BusTrip>();
        }

        public decimal BusId { get; set; }
        public decimal CompanyId { get; set; }
        public decimal BusTypeId { get; set; }
        public string BusNumber { get; set; }
        public int BusYearProd { get; set; }
        public int BusEuroType { get; set; }
        public int BusSeatsQty { get; set; }
        public int BusFloors { get; set; }
        public int BusNumDir { get; set; }
        public int BusRank { get; set; }
        public bool BusArchived { get; set; }
        public DateTime? BusUpdated { get; set; }
        public DateTime BusAdded { get; set; }

        public virtual BusType BusType { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<BusSeat> BusSeat { get; set; }
        public virtual ICollection<BusTrip> BusTrip { get; set; }
    }
}
