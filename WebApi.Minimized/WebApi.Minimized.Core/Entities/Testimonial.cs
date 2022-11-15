using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Testimonial
    {
        public decimal TestimonialId { get; set; }
        public decimal? HotelId { get; set; }
        public string TestimonialTitle { get; set; }
        public string TestimonialName { get; set; }
        public string TestimonialTown { get; set; }
        public string TestimonialCountry { get; set; }
        public string TestimonialText { get; set; }
        public DateTime TestimonialAdded { get; set; }
        public string TestimonialHotel { get; set; }
        public string TestimonialEmail { get; set; }
        public int TestimonialStatus { get; set; }
        public string TestimonialIpaddress { get; set; }
        public int TestimonialRating { get; set; }
        public int TestimonialType { get; set; }
        public string TestimonialDestination { get; set; }
        public string TestimonialManagerReply { get; set; }

        public virtual Hotel Hotel { get; set; }
    }
}
