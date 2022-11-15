using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class AkkProd
    {
        public AkkProd()
        {
            AkkDate = new HashSet<AkkDate>();
            AkkImg = new HashSet<AkkImg>();
            AkkLink = new HashSet<AkkLink>();
        }

        public decimal AkkProdId { get; set; }
        public decimal? PackageId { get; set; }
        public string AkkProdTitle { get; set; }
        public decimal? AkkProdVisaCountryId { get; set; }
        public int? AkkProdNights { get; set; }
        public string AkkProdDates { get; set; }
        public string AkkProdDatesRaw { get; set; }
        public string AkkProdRoute { get; set; }
        public string AkkProdTourUrl { get; set; }
        public decimal? AkkProdPrice { get; set; }
        public string AkkProdCurrency { get; set; }
        public string AkkProdTourType { get; set; }
        public string AkkProdTravelType { get; set; }
        public string AkkProdCountries { get; set; }
        public string AkkProdCategories { get; set; }
        public DateTime? AkkProdUpdated { get; set; }
        public DateTime AkkProdAdded { get; set; }
        public string AkkProdDescription { get; set; }
        public string AkkProdPrices { get; set; }
        public string AkkProdXml { get; set; }
        public int AkkProdTmp { get; set; }
        public decimal? AkkProdPriceEur { get; set; }
        public decimal? AkkProdPriceUsd { get; set; }
        public string AkkProdPrices2 { get; set; }
        public int? AkkProdNightsTo { get; set; }
        public DateTime? AkkProdUpdatedScript { get; set; }

        public virtual ICollection<AkkDate> AkkDate { get; set; }
        public virtual ICollection<AkkImg> AkkImg { get; set; }
        public virtual ICollection<AkkLink> AkkLink { get; set; }
    }
}
