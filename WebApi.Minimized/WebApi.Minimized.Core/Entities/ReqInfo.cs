using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class ReqInfo
    {
        public decimal ReqInfoId { get; set; }
        public decimal RequestId { get; set; }
        public int ReqInfoStatusOld { get; set; }
        public int ReqInfoStatusNew { get; set; }
        public DateTime? ReqInfoNotify { get; set; }
        public DateTime? ReqInfoNotified { get; set; }
        public string ReqInfoText { get; set; }
        public DateTime ReqInfoAdded { get; set; }
        public decimal AddedById { get; set; }
        public decimal ManagerId { get; set; }
        public decimal? ReqInfoAmount { get; set; }
        public string ReqInfoCurrency { get; set; }
        public DateTime? ReqInfoSigned { get; set; }
        public string ReqInfoSignedText { get; set; }
        public string ReqInfoNotifiedText { get; set; }
        public decimal? SignedById { get; set; }
        public int ReqInfoPriority { get; set; }
        public string ReqInfoSms { get; set; }
        public decimal? ReqInfoExcRate { get; set; }
        public string ReqInfoExcCurrency { get; set; }
        public int? ReqInfoAmountType { get; set; }

        public virtual Person AddedBy { get; set; }
        public virtual Person Manager { get; set; }
        public virtual Request Request { get; set; }
    }
}
