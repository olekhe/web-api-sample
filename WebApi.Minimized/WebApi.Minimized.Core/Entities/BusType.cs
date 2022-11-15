using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class BusType
    {
        public BusType()
        {
            Bus = new HashSet<Bus>();
        }

        public decimal BusTypeId { get; set; }
        public string BusTypeModel { get; set; }
        public string BusTypeModelMl { get; set; }
        public int? BusTypeYearProd { get; set; }
        public int BusTypeEuroType { get; set; }
        public int BusTypeSeatsQty { get; set; }
        public int BusTypeFloors { get; set; }
        public int BusTypeNumDir { get; set; }
        public string BusTypeRows { get; set; }
        public int BusTypeRank { get; set; }
        public DateTime? BusTypeUpdated { get; set; }
        public DateTime BusTypeAdded { get; set; }

        public virtual ICollection<Bus> Bus { get; set; }
    }
}
