using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class AkkImg
    {
        public decimal AkkImgId { get; set; }
        public decimal AkkProdId { get; set; }
        public string AkkImgUrl { get; set; }
        public DateTime? AkkImgUpdated { get; set; }
        public DateTime AkkImgAdded { get; set; }

        public virtual AkkProd AkkProd { get; set; }
    }
}
