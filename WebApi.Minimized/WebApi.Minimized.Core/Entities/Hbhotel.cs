using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Hbhotel
    {
        public Hbhotel()
        {
            HbhotelDet = new HashSet<HbhotelDet>();
            Hotel = new HashSet<Hotel>();
        }

        public decimal HbhotelId { get; set; }
        public decimal HbdestId { get; set; }
        public string HbhotelCat { get; set; }
        public decimal HbhotelCode { get; set; }
        public string HbhotelName { get; set; }
        public string HbhotelNameMl { get; set; }
        public string HbhotelDesc { get; set; }
        public string HbhotelDescMl { get; set; }
        public string HbhotelImg1 { get; set; }
        public string HbhotelImg1Local { get; set; }
        public string HbhotelImg1Type { get; set; }
        public string HbhotelImg2 { get; set; }
        public string HbhotelImg2Local { get; set; }
        public string HbhotelImg2Type { get; set; }
        public string HbhotelImg3 { get; set; }
        public string HbhotelImg3Local { get; set; }
        public string HbhotelImg3Type { get; set; }
        public string HbhotelPhone { get; set; }
        public string HbhotelFax { get; set; }
        public string HbhotelEmail { get; set; }
        public string HbhotelUrl { get; set; }
        public DateTime? HbhotelUpdated { get; set; }
        public bool HbhotelPromt { get; set; }
        public DateTime HbhotelAdded { get; set; }
        public bool HbhotelFeatured { get; set; }
        public bool HbhotelStarsPlus { get; set; }
        public int? HbhotelStars { get; set; }
        public int? HbhotelKeys { get; set; }
        public string HbhotelStarsName { get; set; }
        public string HbhotelLatitude { get; set; }
        public string HbhotelLongitude { get; set; }
        public string HbhotelAddress { get; set; }

        public virtual Hbdest Hbdest { get; set; }
        public virtual ICollection<HbhotelDet> HbhotelDet { get; set; }
        public virtual ICollection<Hotel> Hotel { get; set; }
    }
}
