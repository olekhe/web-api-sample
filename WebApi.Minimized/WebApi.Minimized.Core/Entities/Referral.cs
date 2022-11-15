using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Referral
    {
        public decimal ReferralId { get; set; }
        public string ReferralUrl { get; set; }
        public string ReferralClientIp { get; set; }
        public string ReferralAllHttp { get; set; }
        public string ReferralScriptName { get; set; }
        public string ReferralQueryString { get; set; }
        public string ReferralServer { get; set; }
        public decimal? ReferralReturnId { get; set; }
        public int ReferralType { get; set; }
        public DateTime ReferralAdded { get; set; }
    }
}
