using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Ownhotel
    {
        public Ownhotel()
        {
            Hotel = new HashSet<Hotel>();
            OwnhotelDet = new HashSet<OwnhotelDet>();
        }

        public decimal OwnhotelId { get; set; }
        public int? OwnhotelStars { get; set; }
        public bool OwnhotelStarsPlus { get; set; }
        public string OwnhotelName { get; set; }
        public string OwnhotelNameMl { get; set; }
        public string OwnhotelDesc { get; set; }
        public string OwnhotelDescMl { get; set; }
        public string OwnhotelImg1 { get; set; }
        public string OwnhotelImg1Local { get; set; }
        public string OwnhotelImg1Type { get; set; }
        public string OwnhotelImg2 { get; set; }
        public string OwnhotelImg2Local { get; set; }
        public string OwnhotelImg2Type { get; set; }
        public string OwnhotelImg3 { get; set; }
        public string OwnhotelImg3Local { get; set; }
        public string OwnhotelImg3Type { get; set; }
        public string OwnhotelPhone { get; set; }
        public string OwnhotelFax { get; set; }
        public string OwnhotelEmail { get; set; }
        public string OwnhotelUrl { get; set; }
        public DateTime? OwnhotelUpdated { get; set; }
        public bool OwnhotelPromt { get; set; }
        public DateTime OwnhotelAdded { get; set; }
        public string OwnhotelStarsName { get; set; }
        public int? OwnhotelKeys { get; set; }

        public virtual ICollection<Hotel> Hotel { get; set; }
        public virtual ICollection<OwnhotelDet> OwnhotelDet { get; set; }
    }
}
