using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Hotel
    {
        public Hotel()
        {
            Accom = new HashSet<Accom>();
            HotelImage = new HashSet<HotelImage>();
            Review = new HashSet<Review>();
            Testimonial = new HashSet<Testimonial>();
        }

        public decimal HotelId { get; set; }
        public decimal DestId { get; set; }
        public decimal? HbhotelId { get; set; }
        public string HotelName { get; set; }
        public string HotelNameMl { get; set; }
        public decimal? HotelRating { get; set; }
        public int HotelFeatured { get; set; }
        public DateTime? HotelAdded { get; set; }
        public decimal? OwnhotelId { get; set; }
        public int? HotelStars { get; set; }
        public bool HotelStarsPlus { get; set; }
        public string HotelDesc { get; set; }
        public string HotelDescMl { get; set; }
        public string HotelImg1 { get; set; }
        public bool HotelPromt { get; set; }
        public string HotelStarsName { get; set; }
        public int? HotelKeys { get; set; }
        public string HotelImg1Local { get; set; }
        public int? HotelRatingQty { get; set; }
        public string HotelLatitude { get; set; }
        public string HotelLongitude { get; set; }
        public int? GoogleMap { get; set; }
        public int Hbinfo { get; set; }
        public string HotelAddress { get; set; }
        public string HotelDesc1 { get; set; }
        public string HotelDesc1Ml { get; set; }
        public decimal? TthotelId { get; set; }
        public decimal? HoohotelId { get; set; }
        public string HotelHtml { get; set; }
        public int HotelViewed { get; set; }
        public string HotelHtmlorig { get; set; }
        public string HotelType { get; set; }
        public string HotelImgs { get; set; }
        public DateTime? HotelUpdated { get; set; }
        public string HotelIncoming { get; set; }
        public string HotelIncoming2 { get; set; }
        public string HotelHtmlorig2 { get; set; }
        public string HotelImgs2 { get; set; }
        public bool HotelFix { get; set; }
        public decimal? HotelPriceFrom { get; set; }
        public string HotelPriceCurrency { get; set; }
        public string HotelPriceDetails { get; set; }
        public string HotelTypeMl { get; set; }

        public virtual Dest Dest { get; set; }
        public virtual Hbhotel Hbhotel { get; set; }
        public virtual Hoohotel Hoohotel { get; set; }
        public virtual Ownhotel Ownhotel { get; set; }
        public virtual Tthotel Tthotel { get; set; }
        public virtual ICollection<Accom> Accom { get; set; }
        public virtual ICollection<HotelImage> HotelImage { get; set; }
        public virtual ICollection<Review> Review { get; set; }
        public virtual ICollection<Testimonial> Testimonial { get; set; }
    }
}
