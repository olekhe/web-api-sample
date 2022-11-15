using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Setting
    {
        public Setting()
        {
            SettingValue = new HashSet<SettingValue>();
        }

        public decimal SettingId { get; set; }
        public string SettingPath1 { get; set; }
        public string SettingPath2 { get; set; }
        public string SettingPath3 { get; set; }
        public int SettingType { get; set; }
        public bool SettingRequired { get; set; }
        public string SettingString { get; set; }
        public decimal? SettingNumeric { get; set; }
        public string SettingText { get; set; }
        public DateTime? SettingDate { get; set; }
        public bool SettingForHtml { get; set; }

        public virtual ICollection<SettingValue> SettingValue { get; set; }
    }
}
