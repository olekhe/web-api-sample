using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class ContactInfo
    {
        public decimal ContactInfoId { get; set; }
        public decimal ContactId { get; set; }
        public int ContactInfoType { get; set; }
        public string ContactInfoDestination { get; set; }
        public decimal? ContactInfoBudget { get; set; }
        public string ContactInfoDetails { get; set; }
        public DateTime? ContactInfoNotify { get; set; }
        public bool ContactInfoNotified { get; set; }
        public DateTime ContactInfoAdded { get; set; }
        public bool ContactInfoBooking { get; set; }
        public DateTime? ContactInfoFromDate { get; set; }
        public DateTime? ContactInfoToDate { get; set; }
        public string ContactInfoCurrency { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
