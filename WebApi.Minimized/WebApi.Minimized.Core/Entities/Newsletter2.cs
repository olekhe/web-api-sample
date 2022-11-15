using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Newsletter2
    {
        public decimal NewsletterId { get; set; }
        public string NewsletterName { get; set; }
        public string NewsletterEmail { get; set; }
        public string NewsletterIpaddress { get; set; }
        public DateTime NewsletterAdded { get; set; }
        public int NewsletterStatus { get; set; }
        public int NewsletterType { get; set; }
        public Guid NewsletterGuid { get; set; }
        public DateTime? NewsletterSent { get; set; }
        public int NewsletterSentQty { get; set; }
        public string NewsletterComments { get; set; }
        public int NewsletterGroup { get; set; }
        public string NewsletterTag { get; set; }
        public string NewsletterPhone { get; set; }
    }
}
