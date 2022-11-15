using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class AkkCtg
    {
        public AkkCtg()
        {
            AkkLink = new HashSet<AkkLink>();
        }

        public decimal AkkCtgId { get; set; }
        public string AkkCtgName { get; set; }
        public DateTime? AkkCtgUpdated { get; set; }
        public DateTime AkkCtgAdded { get; set; }
        public int AkkCtgStatus { get; set; }
        public int? PackageSubtype { get; set; }
        public decimal? AkkCtgParentId { get; set; }

        public virtual ICollection<AkkLink> AkkLink { get; set; }
    }
}
