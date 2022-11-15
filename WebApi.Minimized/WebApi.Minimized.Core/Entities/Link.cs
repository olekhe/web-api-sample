using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Link
    {
        public decimal LinkId { get; set; }
        public string LinkBacklinkUrl { get; set; }
        public string LinkUrl { get; set; }
        public string LinkTitle { get; set; }
        public string LinkDescription { get; set; }
        public string LinkContactName { get; set; }
        public string LinkContactEmail { get; set; }
        public string LinkContactPhone { get; set; }
        public string LinkNote { get; set; }
        public int LinkCategory { get; set; }
        public int LinkPageNo { get; set; }
        public DateTime LinkCreated { get; set; }
        public int LinkStatus { get; set; }
    }
}
