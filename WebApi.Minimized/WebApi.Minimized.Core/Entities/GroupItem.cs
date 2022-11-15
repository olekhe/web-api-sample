using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class GroupItem
    {
        public GroupItem()
        {
            BusPrice = new HashSet<BusPrice>();
            GroupMember = new HashSet<GroupMember>();
        }

        public decimal GroupItemId { get; set; }
        public string GroupItemName { get; set; }
        public DateTime GroupItemAdded { get; set; }
        public decimal? GroupItemAddedById { get; set; }
        public DateTime? GroupItemUpdated { get; set; }
        public decimal? GroupItemUpdatedById { get; set; }
        public int? GroupItemType { get; set; }
        public decimal? GroupItemCommision1 { get; set; }
        public decimal? GroupItemCommision2 { get; set; }
        public decimal? GroupItemCommision3 { get; set; }
        public decimal? GroupItemCommision4 { get; set; }

        public virtual ICollection<BusPrice> BusPrice { get; set; }
        public virtual ICollection<GroupMember> GroupMember { get; set; }
    }
}
