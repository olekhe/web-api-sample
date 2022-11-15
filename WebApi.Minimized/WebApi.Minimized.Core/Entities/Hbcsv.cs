using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Hbcsv
    {
        public decimal HbcsvId { get; set; }
        public decimal HbcsvHotelCode { get; set; }
        public string HbcsvDestCode { get; set; }
        public decimal HbcsvZoneCode { get; set; }
        public int HbcsvCount { get; set; }
    }
}
