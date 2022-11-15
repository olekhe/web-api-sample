using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class ObjectLog
    {
        public decimal ObjectLogId { get; set; }
        public decimal AddedById { get; set; }
        public string AddedByName { get; set; }
        public decimal ObjectId { get; set; }
        public string ObjectLogTable { get; set; }
        public string ObjectLogOperation { get; set; }
        public string ObjectLogNote { get; set; }
        public string ObjectLogBefore { get; set; }
        public string ObjectLogAfter { get; set; }
        public string ObjectLogIpaddress { get; set; }
        public DateTime ObjectLogAdded { get; set; }
    }
}
