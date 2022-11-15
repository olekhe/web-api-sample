using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Discuss
    {
        public decimal DiscussId { get; set; }
        public int DiscussStatus { get; set; }
        public int? DiscussSubStatus { get; set; }
        public string DiscussTag { get; set; }
        public decimal? DiscussRequestId { get; set; }
        public string DiscussName { get; set; }
        public string DiscussResidence { get; set; }
        public string DiscussEmail { get; set; }
        public string DiscussPhone { get; set; }
        public bool DiscussPhoneViberEnabled { get; set; }
        public bool DiscussPhoneWhatsAppEnabled { get; set; }
        public string DiscussPhone2 { get; set; }
        public string DiscussPhone3 { get; set; }
        public string DiscussSkype { get; set; }
        public string DiscussDestination { get; set; }
        public string DiscussDates { get; set; }
        public string DiscussCalculation { get; set; }
        public DateTime? DiscussNotify { get; set; }
        public string DiscussComments { get; set; }
        public DateTime DiscussAdded { get; set; }
        public decimal DiscussAddedById { get; set; }
        public DateTime? DiscussUpdated { get; set; }
        public int? DiscussUpdatedById { get; set; }
        public bool DiscussArchived { get; set; }
    }
}
