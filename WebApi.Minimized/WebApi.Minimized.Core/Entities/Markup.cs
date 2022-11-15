using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Markup
    {
        public decimal MarkupId { get; set; }
        public string MarkupProvider { get; set; }
        public decimal MarkupPercent { get; set; }
        public decimal MarkupPercentMin { get; set; }
        public DateTime MarkupUpdated { get; set; }
    }
}
