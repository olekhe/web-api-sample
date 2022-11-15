using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class ReqPassport
    {
        public ReqPassport()
        {
            BusTripSeatReqPassportId1Navigation = new HashSet<BusTripSeat>();
            BusTripSeatReqPassportId2Navigation = new HashSet<BusTripSeat>();
            BusTripSeatReqPassportId3Navigation = new HashSet<BusTripSeat>();
            BusTripSeatReqPassportId4Navigation = new HashSet<BusTripSeat>();
            BusTripSeatReqPassportId5Navigation = new HashSet<BusTripSeat>();
        }

        public decimal ReqPassportId { get; set; }
        public decimal RequestId { get; set; }
        public decimal? AddedById { get; set; }
        public bool ReqPassportLead { get; set; }
        public string ReqPassportTitle { get; set; }
        public string ReqPassportFirstName { get; set; }
        public string ReqPassportLastName { get; set; }
        public string ReqPassportSeries { get; set; }
        public string ReqPassportNumber { get; set; }
        public DateTime? ReqPassportDateOfBirth { get; set; }
        public DateTime? ReqPassportDateOfExpiry { get; set; }
        public string ReqPassportIssuedBy { get; set; }
        public DateTime ReqPassportAdded { get; set; }
        public string ReqPassportNote { get; set; }
        public decimal? ChflightSeatThereId { get; set; }
        public decimal? ChflightSeatBackId { get; set; }
        public string ReqPassportContactPhone { get; set; }
        public string ReqPassportExt1 { get; set; }

        public virtual Person AddedBy { get; set; }
        public virtual ChflightSeat ChflightSeatBack { get; set; }
        public virtual ChflightSeat ChflightSeatThere { get; set; }
        public virtual Request Request { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeatReqPassportId1Navigation { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeatReqPassportId2Navigation { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeatReqPassportId3Navigation { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeatReqPassportId4Navigation { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeatReqPassportId5Navigation { get; set; }
    }
}
