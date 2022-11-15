using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class AkkDate
    {
        public decimal AkkDateId { get; set; }
        public decimal AkkProdId { get; set; }
        public DateTime AkkDateDate { get; set; }
        public DateTime? AkkDateDateTo { get; set; }
        public string AkkDateSpecial { get; set; }
        public DateTime? AkkDateUpdated { get; set; }
        public DateTime AkkDateAdded { get; set; }

        public virtual AkkProd AkkProd { get; set; }
    }
}
