using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class CorpClient
    {
        public decimal CorpClientId { get; set; }
        public string CorpClientName { get; set; }
        public string CorpClientEmail { get; set; }
        public string CorpClientPhone { get; set; }
        public DateTime CorpClientAdded { get; set; }
        public DateTime? CorpClientAdvSent { get; set; }
        public int CorpClientAdvNum { get; set; }
    }
}
