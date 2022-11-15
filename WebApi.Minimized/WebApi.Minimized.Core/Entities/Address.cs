using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Address
    {
        public decimal AddressId { get; set; }
        public string AddressAddress1 { get; set; }
        public string AddressAddress2 { get; set; }
        public string AddressTitle { get; set; }
        public string AddressTown { get; set; }
        public string AddressAddress3 { get; set; }
        public string AddressPostalCode { get; set; }
        public decimal CountryId { get; set; }
        public string AddressStateText { get; set; }
        public decimal? StateId { get; set; }
        public decimal? CompanyId { get; set; }
        public DateTime AddressCreated { get; set; }
        public string AddressNote { get; set; }
        public decimal? PersonId { get; set; }
        public bool AddressPrimary { get; set; }
        public DateTime? AddressUpdated { get; set; }
        public decimal? AddressAddedById { get; set; }
        public decimal? AddressUpdatedById { get; set; }
        public DateTime? AddressAdded { get; set; }

        public virtual Company Company { get; set; }
        public virtual Country Country { get; set; }
        public virtual Person Person { get; set; }
        public virtual State State { get; set; }
    }
}
