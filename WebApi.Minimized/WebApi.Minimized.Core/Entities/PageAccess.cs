using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class PageAccess
    {
        public decimal PageAccessId { get; set; }
        public string PageAccessPage { get; set; }
        public string PageAccessMenu1 { get; set; }
        public string PageAccessMenu2 { get; set; }
        public string PageAccessMenu3 { get; set; }
        public int PageAccessMenuRank { get; set; }
        public bool PageAccessLevel1 { get; set; }
        public bool PageAccessLevel2 { get; set; }
        public bool PageAccessLevel3 { get; set; }
        public bool PageAccessLevel4 { get; set; }
        public bool PageAccessLevel5 { get; set; }
    }
}
