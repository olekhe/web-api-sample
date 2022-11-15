using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class AccomDisc
    {
        public decimal AccomDiscId { get; set; }
        public decimal AccomId { get; set; }
        public string AccomDiscDescription { get; set; }
        public decimal AccomDiscDiscount { get; set; }
        public string AccomDiscNote { get; set; }
        public DateTime AccomDiscAdded { get; set; }

        public virtual Accom Accom { get; set; }
    }
}
