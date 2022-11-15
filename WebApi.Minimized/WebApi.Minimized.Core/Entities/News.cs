using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class News
    {
        public decimal NewsId { get; set; }
        public string NewsTitle { get; set; }
        public string NewsUrl { get; set; }
        public string NewsText { get; set; }
        public DateTime NewsAdded { get; set; }
        public int NewsStatus { get; set; }
        public DateTime NewsPublished { get; set; }
    }
}
