using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class AgrLogin
    {
        public decimal AgrLoginId { get; set; }
        public decimal AgreementId { get; set; }
        public decimal ManagerId { get; set; }
        public bool AgrLoginArchived { get; set; }
        public bool AgrLoginPrimary { get; set; }
        public string AgrLoginUserName { get; set; }
        public string AgrLoginPwd { get; set; }
        public string AgrLoginExt { get; set; }
        public string AgrLoginUrl { get; set; }
        public string AgrLoginNote { get; set; }
        public DateTime AgrLoginAdded { get; set; }
        public decimal? AgrLoginAddedById { get; set; }
        public DateTime? AgrLoginUpdated { get; set; }
        public decimal? AgrLoginUpdatedById { get; set; }

        public virtual Agreement Agreement { get; set; }
        public virtual Person Manager { get; set; }
    }
}
