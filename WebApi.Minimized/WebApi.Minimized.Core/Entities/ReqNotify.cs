using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class ReqNotify
    {
        public decimal ReqNotifyId { get; set; }
        public bool? ReqNotifyEnabled { get; set; }
        public int? ReqNotifyType { get; set; }
        public int? ReqNotifyStatusOld { get; set; }
        public int ReqNotifyStatusNew { get; set; }
        public string ReqNotifyText { get; set; }
        public string ReqNotifyInterval { get; set; }
        public int ReqNotifyNumber { get; set; }
        public int ReqNotifyIntervalDate { get; set; }
        public int ReqNotifyRank { get; set; }
        public DateTime ReqNotifyAdded { get; set; }
        public int ReqNotifyPriority { get; set; }
    }
}
