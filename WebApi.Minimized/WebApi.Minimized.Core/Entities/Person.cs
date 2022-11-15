using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Person
    {
        public Person()
        {
            Accom = new HashSet<Accom>();
            Address = new HashSet<Address>();
            AgrLogin = new HashSet<AgrLogin>();
            AgrProxy = new HashSet<AgrProxy>();
            Booking = new HashSet<Booking>();
            CarHire = new HashSet<CarHire>();
            Doc = new HashSet<Doc>();
            Flight = new HashSet<Flight>();
            GroupMember = new HashSet<GroupMember>();
            Insurance = new HashSet<Insurance>();
            Message = new HashSet<Message>();
            MessageBody = new HashSet<MessageBody>();
            ReqInfoAddedBy = new HashSet<ReqInfo>();
            ReqInfoManager = new HashSet<ReqInfo>();
            ReqPassport = new HashSet<ReqPassport>();
            RequestAddedBy = new HashSet<Request>();
            RequestManager = new HashSet<Request>();
            Review = new HashSet<Review>();
            Transfer = new HashSet<Transfer>();
        }

        public decimal PersonId { get; set; }
        public string PersonTitle { get; set; }
        public int PersonAccountLevel { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
        public decimal? CompanyId { get; set; }
        public string PersonEmail { get; set; }
        public string PersonPhone { get; set; }
        public string PersonMobile { get; set; }
        public DateTime? PersonBirthday { get; set; }
        public bool PersonAccess { get; set; }
        public string PersonPassword { get; set; }
        public bool PersonSys { get; set; }
        public bool PersonPrimary { get; set; }
        public int PersonLoginCount { get; set; }
        public DateTime? PersonLastLogin { get; set; }
        public DateTime? PersonLastActive { get; set; }
        public string PersonLastIp { get; set; }
        public string PersonNote { get; set; }
        public DateTime PersonCreated { get; set; }
        public DateTime? PersonUpdated { get; set; }
        public decimal? PersonAddedById { get; set; }
        public decimal? PersonUpdatedById { get; set; }
        public DateTime? PersonAdded { get; set; }
        public string PersonMiddleName { get; set; }
        public bool PersonArchived { get; set; }
        public string PersonColorBg { get; set; }
        public string PersonColorText { get; set; }
        public string PersonLabel { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Accom> Accom { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<AgrLogin> AgrLogin { get; set; }
        public virtual ICollection<AgrProxy> AgrProxy { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<CarHire> CarHire { get; set; }
        public virtual ICollection<Doc> Doc { get; set; }
        public virtual ICollection<Flight> Flight { get; set; }
        public virtual ICollection<GroupMember> GroupMember { get; set; }
        public virtual ICollection<Insurance> Insurance { get; set; }
        public virtual ICollection<Message> Message { get; set; }
        public virtual ICollection<MessageBody> MessageBody { get; set; }
        public virtual ICollection<ReqInfo> ReqInfoAddedBy { get; set; }
        public virtual ICollection<ReqInfo> ReqInfoManager { get; set; }
        public virtual ICollection<ReqPassport> ReqPassport { get; set; }
        public virtual ICollection<Request> RequestAddedBy { get; set; }
        public virtual ICollection<Request> RequestManager { get; set; }
        public virtual ICollection<Review> Review { get; set; }
        public virtual ICollection<Transfer> Transfer { get; set; }
    }
}
