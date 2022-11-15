using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class OwnhotelDet
    {
        public decimal OwnhotelDetId { get; set; }
        public decimal OwnhotelFacId { get; set; }
        public decimal OwnhotelId { get; set; }
        public int? OwnhotelDetNumber { get; set; }

        public virtual Ownhotel Ownhotel { get; set; }
        public virtual OwnhotelFac OwnhotelFac { get; set; }
    }
}
