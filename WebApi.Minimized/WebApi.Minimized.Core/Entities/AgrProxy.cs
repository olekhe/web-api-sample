using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class AgrProxy
    {
        public decimal AgrProxyId { get; set; }
        public decimal AgreementId { get; set; }
        public decimal ManagerId { get; set; }
        public string AgrProxyTitle { get; set; }
        public string AgrProxyByPerson { get; set; }
        public string AgrProxyNumber { get; set; }
        public DateTime AgrProxyDate { get; set; }
        public DateTime? AgrProxyValidTill { get; set; }
        public string AgrProxyNote { get; set; }
        public DateTime AgrProxyAdded { get; set; }
        public decimal? AgrProxyAddedById { get; set; }
        public DateTime? AgrProxyUpdated { get; set; }
        public decimal? AgrProxyUpdatedById { get; set; }

        public virtual Agreement Agreement { get; set; }
        public virtual Person Manager { get; set; }
    }
}
