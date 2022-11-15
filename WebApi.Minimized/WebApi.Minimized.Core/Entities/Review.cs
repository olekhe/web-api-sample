using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Review
    {
        public decimal ReviewId { get; set; }
        public decimal? PersonId { get; set; }
        public decimal HotelId { get; set; }
        public int ReviewStatus { get; set; }
        public string ReviewName { get; set; }
        public string ReviewEmail { get; set; }
        public string ReviewTown { get; set; }
        public string ReviewCountry { get; set; }
        public DateTime ReviewFromDate { get; set; }
        public DateTime ReviewToDate { get; set; }
        public string ReviewText { get; set; }
        public decimal ReviewRating { get; set; }
        public int ReviewRoomFacilities { get; set; }
        public int ReviewRoomCleaning { get; set; }
        public int ReviewReceptionStaff { get; set; }
        public int ReviewFood { get; set; }
        public int ReviewHotelTerritory { get; set; }
        public int ReviewHotelLocation { get; set; }
        public int? ReviewEntertainment { get; set; }
        public int? ReviewSport { get; set; }
        public int? ReviewBeach { get; set; }
        public string ReviewPool { get; set; }
        public int ReviewHotelType { get; set; }
        public int ReviewOverallImpression { get; set; }
        public int ReviewEaseUseWebsite { get; set; }
        public int ReviewContentAvailable { get; set; }
        public bool? ReviewReccomendToFriend { get; set; }
        public string ReviewIpaddress { get; set; }
        public DateTime ReviewAdded { get; set; }
        public string ReviewTextEn { get; set; }
        public DateTime? ReviewUpdated { get; set; }
        public decimal? ReviewUpdatedById { get; set; }
        public decimal? ReviewAddedById { get; set; }

        public virtual Hotel Hotel { get; set; }
        public virtual Person Person { get; set; }
    }
}
