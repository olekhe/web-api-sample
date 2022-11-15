using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class SettingValue
    {
        public decimal SettingValueId { get; set; }
        public decimal? SettingId { get; set; }
        public string SettingValueCaption { get; set; }
        public string SettingValueString { get; set; }
        public decimal? SettingValueNumeric { get; set; }
        public string SettingValueText { get; set; }
        public DateTime? SettingValueDate { get; set; }
        public int SettingValueRank { get; set; }

        public virtual Setting Setting { get; set; }
    }
}
