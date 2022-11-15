using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class HbhotelFac
    {
        public HbhotelFac()
        {
            HbhotelDet = new HashSet<HbhotelDet>();
        }

        public decimal HbhotelFacId { get; set; }
        public int HbhotelFacType { get; set; }
        public string HbhotelFacName { get; set; }
        public string HbhotelFacNameMl { get; set; }
        public DateTime HbhotelFacAdded { get; set; }

        public virtual ICollection<HbhotelDet> HbhotelDet { get; set; }
    }
}
