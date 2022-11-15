using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Contact
    {
        public Contact()
        {
            ContactInfo = new HashSet<ContactInfo>();
        }

        public decimal ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactCompany { get; set; }
        public string ContactPhone { get; set; }
        public string ContactPhone2 { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNote { get; set; }
        public DateTime ContactAdded { get; set; }

        public virtual ICollection<ContactInfo> ContactInfo { get; set; }
    }
}
