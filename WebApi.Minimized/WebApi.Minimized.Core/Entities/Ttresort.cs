using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Ttresort
    {
        public Ttresort()
        {
            Dest = new HashSet<Dest>();
        }

        public decimal TtresortId { get; set; }
        public decimal TtresortKey { get; set; }
        public string TtresortName { get; set; }
        public decimal TtresortCountryKey { get; set; }
        public DateTime TtresortAdded { get; set; }

        public virtual ICollection<Dest> Dest { get; set; }
    }
}
