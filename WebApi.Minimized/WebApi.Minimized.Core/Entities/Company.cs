using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Company
    {
        public Company()
        {
            AccomAgency = new HashSet<Accom>();
            AccomSupplier = new HashSet<Accom>();
            Address = new HashSet<Address>();
            Agreement = new HashSet<Agreement>();
            AirTicket = new HashSet<AirTicket>();
            Bus = new HashSet<Bus>();
            CarHireAgency = new HashSet<CarHire>();
            CarHireSupplier = new HashSet<CarHire>();
            Chflight = new HashSet<Chflight>();
            Chmap = new HashSet<Chmap>();
            Excursion = new HashSet<Excursion>();
            FlightAgency = new HashSet<Flight>();
            FlightSupplier = new HashSet<Flight>();
            GroupMember = new HashSet<GroupMember>();
            InsuranceAgency = new HashSet<Insurance>();
            InsuranceSupplier = new HashSet<Insurance>();
            Message = new HashSet<Message>();
            MessageBody = new HashSet<MessageBody>();
            Package = new HashSet<Package>();
            Person = new HashSet<Person>();
            RequestAgency = new HashSet<Request>();
            RequestSupplier = new HashSet<Request>();
            TransferAgency = new HashSet<Transfer>();
            TransferSupplier = new HashSet<Transfer>();
        }

        public decimal CompanyId { get; set; }
        public int CompanyType { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyPhone2 { get; set; }
        public string CompanyFax { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyUrl { get; set; }
        public string CompanyNote { get; set; }
        public string CompanyEmailInfo { get; set; }
        public DateTime CompanyCreated { get; set; }
        public string CompanyEmailSales { get; set; }
        public bool CompanyAccess { get; set; }
        public DateTime? CompanyAdded { get; set; }
        public decimal? CompanyAddedById { get; set; }
        public decimal? CompanyUpdatedById { get; set; }
        public DateTime? CompanyUpdated { get; set; }
        public string CompanyTitle { get; set; }
        public int CompanyStatus { get; set; }
        public int CompanyRank { get; set; }
        public string CompanyAgrNumber { get; set; }
        public DateTime? CompanyAgrDate { get; set; }
        public DateTime? CompanyAgrValidTill { get; set; }
        public string CompanyAgrLoginUrl { get; set; }
        public string CompanyAgrLoginExt { get; set; }
        public string CompanyAgrLogin { get; set; }
        public string CompanyAgrPwd { get; set; }
        public string CompanyAgrNote { get; set; }
        public bool CompanyArchived { get; set; }
        public decimal? CompanyEdrpou { get; set; }
        public string CompanyLabel { get; set; }

        public virtual ICollection<Accom> AccomAgency { get; set; }
        public virtual ICollection<Accom> AccomSupplier { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Agreement> Agreement { get; set; }
        public virtual ICollection<AirTicket> AirTicket { get; set; }
        public virtual ICollection<Bus> Bus { get; set; }
        public virtual ICollection<CarHire> CarHireAgency { get; set; }
        public virtual ICollection<CarHire> CarHireSupplier { get; set; }
        public virtual ICollection<Chflight> Chflight { get; set; }
        public virtual ICollection<Chmap> Chmap { get; set; }
        public virtual ICollection<Excursion> Excursion { get; set; }
        public virtual ICollection<Flight> FlightAgency { get; set; }
        public virtual ICollection<Flight> FlightSupplier { get; set; }
        public virtual ICollection<GroupMember> GroupMember { get; set; }
        public virtual ICollection<Insurance> InsuranceAgency { get; set; }
        public virtual ICollection<Insurance> InsuranceSupplier { get; set; }
        public virtual ICollection<Message> Message { get; set; }
        public virtual ICollection<MessageBody> MessageBody { get; set; }
        public virtual ICollection<Package> Package { get; set; }
        public virtual ICollection<Person> Person { get; set; }
        public virtual ICollection<Request> RequestAgency { get; set; }
        public virtual ICollection<Request> RequestSupplier { get; set; }
        public virtual ICollection<Transfer> TransferAgency { get; set; }
        public virtual ICollection<Transfer> TransferSupplier { get; set; }
    }
}
