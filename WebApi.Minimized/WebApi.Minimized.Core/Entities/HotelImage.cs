using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class HotelImage
    {
        public decimal HotelImageId { get; set; }
        public decimal HotelId { get; set; }
        public bool HotelImageEnabled { get; set; }
        public string HotelImageUrl { get; set; }
        public string HotelImageTitle { get; set; }
        public string HotelImageTitleMl { get; set; }
        public DateTime HotelImageAdded { get; set; }

        public virtual Hotel Hotel { get; set; }
    }
}
