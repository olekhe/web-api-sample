using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Tthotel
    {
        public Tthotel()
        {
            Hotel = new HashSet<Hotel>();
        }

        public decimal TthotelId { get; set; }
        public decimal? HotelId { get; set; }
        public decimal TthotelKey { get; set; }
        public string TthotelName { get; set; }
        public decimal TthotelCountryKey { get; set; }
        public decimal TthotelCityKey { get; set; }
        public decimal TthotelResortKey { get; set; }
        public decimal TthotelDescId { get; set; }
        public string TthotelDesc { get; set; }
        public string TthotelDesc1 { get; set; }
        public string TthotelImg1Local { get; set; }
        public string TthotelImg2Local { get; set; }
        public string TthotelImg3Local { get; set; }
        public DateTime TthotelAdded { get; set; }
        public int? TthotelStars { get; set; }
        public string TthotelNameMl { get; set; }
        public string TthotelStarsName { get; set; }

        public virtual ICollection<Hotel> Hotel { get; set; }
    }
}
