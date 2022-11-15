using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class BusPrice
    {
        public decimal BusPriceId { get; set; }
        public decimal BusRouteId { get; set; }
        public DateTime? BusPriceFromDate { get; set; }
        public DateTime? BusPriceToDate { get; set; }
        public int? BusPriceDaysMin { get; set; }
        public int? BusPriceDaysMax { get; set; }
        public int? BusPriceSeatNumMin { get; set; }
        public int? BusPriceSeatNumMax { get; set; }
        public int? BusPriceTripQtyTill { get; set; }
        public string BusPriceType { get; set; }
        public decimal BusPricePrice { get; set; }
        public string BusPriceCurrency { get; set; }
        public bool BusPriceEnabled { get; set; }
        public bool BusPriceArchived { get; set; }
        public int BusPriceRank { get; set; }
        public DateTime? BusPriceUpdated { get; set; }
        public DateTime BusPriceAdded { get; set; }
        public string BusPriceLabel { get; set; }
        public decimal? GroupItemId { get; set; }

        public virtual BusRoute BusRoute { get; set; }
        public virtual GroupItem GroupItem { get; set; }
    }
}
