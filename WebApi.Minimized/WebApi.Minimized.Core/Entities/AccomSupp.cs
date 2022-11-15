using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class AccomSupp
    {
        public decimal AccomSuppId { get; set; }
        public decimal AccomId { get; set; }
        public string AccomSuppDescription { get; set; }
        public decimal AccomSuppTotalCost { get; set; }
        public decimal AccomSuppNetCost { get; set; }
        public string AccomSuppNote { get; set; }
        public DateTime AccomSuppAdded { get; set; }

        public virtual Accom Accom { get; set; }
    }
}
