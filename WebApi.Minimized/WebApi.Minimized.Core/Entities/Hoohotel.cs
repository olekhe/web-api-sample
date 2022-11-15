using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Hoohotel
    {
        public Hoohotel()
        {
            Hotel = new HashSet<Hotel>();
        }

        public decimal HoohotelId { get; set; }
        public decimal HoohotelDestCode { get; set; }
        public string HoohotelName { get; set; }
        public int HoohotelCategoryCode { get; set; }
        public DateTime HoohotelAdded { get; set; }
        public decimal? HoohotelCode { get; set; }

        public virtual ICollection<Hotel> Hotel { get; set; }
    }
}
