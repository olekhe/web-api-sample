using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class HbhotelDet
    {
        public decimal HbhotelDetId { get; set; }
        public decimal HbhotelFacId { get; set; }
        public decimal HbhotelId { get; set; }
        public int? HbhotelDetNumber { get; set; }
        public bool HbhotelDetFee { get; set; }

        public virtual Hbhotel Hbhotel { get; set; }
        public virtual HbhotelFac HbhotelFac { get; set; }
    }
}
