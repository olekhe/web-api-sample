using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class AccomGuest
    {
        public decimal AccomGuestId { get; set; }
        public decimal AccomId { get; set; }
        public string AccomGuestTitle { get; set; }
        public string AccomGuestFirstName { get; set; }
        public string AccomGuestLastName { get; set; }
        public int AccomGuestAge { get; set; }
    }
}
