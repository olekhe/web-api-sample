using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Keyword
    {
        public decimal KeywordId { get; set; }
        public string KeywordText { get; set; }
        public string KeywordTag { get; set; }
    }
}
