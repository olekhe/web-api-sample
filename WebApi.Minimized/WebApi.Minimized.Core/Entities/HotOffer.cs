using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class HotOffer
    {
        public decimal HotOfferId { get; set; }
        public int HotOfferStatus { get; set; }
        public string HotOfferTitle { get; set; }
        public string HotOfferText { get; set; }
        public string HotOfferHtml { get; set; }
        public DateTime HotOfferPublished { get; set; }
        public DateTime HotOfferAdded { get; set; }
    }
}
