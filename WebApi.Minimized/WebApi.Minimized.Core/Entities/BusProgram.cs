using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class BusProgram
    {
        public BusProgram()
        {
            BusRoute = new HashSet<BusRoute>();
        }

        public decimal BusProgramId { get; set; }
        public decimal CountryId { get; set; }
        public string BusProgramName { get; set; }
        public string BusProgramNameMl { get; set; }
        public DateTime BusProgramDateStart { get; set; }
        public DateTime BusProgramDateEnd { get; set; }
        public string BusProgramNote { get; set; }
        public bool? BusProgramEnabled { get; set; }
        public bool BusProgramArchived { get; set; }
        public DateTime? BusProgramUpdated { get; set; }
        public DateTime BusProgramAdded { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<BusRoute> BusRoute { get; set; }
    }
}
