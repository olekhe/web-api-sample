using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class OwnhotelFac
    {
        public OwnhotelFac()
        {
            OwnhotelDet = new HashSet<OwnhotelDet>();
        }

        public decimal OwnhotelFacId { get; set; }
        public int OwnhotelFacType { get; set; }
        public string OwnhotelFacName { get; set; }
        public string OwnhotelFacNameMl { get; set; }
        public DateTime OwnhotelFacAdded { get; set; }

        public virtual ICollection<OwnhotelDet> OwnhotelDet { get; set; }
    }
}
