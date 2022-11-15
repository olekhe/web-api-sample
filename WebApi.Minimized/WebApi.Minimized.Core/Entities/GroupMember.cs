using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class GroupMember
    {
        public decimal GroupMemberId { get; set; }
        public decimal GroupItemId { get; set; }
        public decimal? CompanyId { get; set; }
        public decimal? PersonId { get; set; }
        public DateTime GroupMemberAdded { get; set; }
        public decimal? GroupMemberAddedById { get; set; }

        public virtual Company Company { get; set; }
        public virtual GroupItem GroupItem { get; set; }
        public virtual Person Person { get; set; }
    }
}
