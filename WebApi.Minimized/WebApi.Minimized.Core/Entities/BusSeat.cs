using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class BusSeat
    {
        public decimal BusSeatId { get; set; }
        public decimal BusId { get; set; }
        public int BusSeatFloor { get; set; }
        public int BusSeatRow { get; set; }
        public int? BusSeatCol1Num { get; set; }
        public string BusSeatCol1Type { get; set; }
        public bool BusSeatCol1Tv { get; set; }
        public int? BusSeatCol2Num { get; set; }
        public string BusSeatCol2Type { get; set; }
        public bool BusSeatCol2Tv { get; set; }
        public int? BusSeatCol3Num { get; set; }
        public string BusSeatCol3Type { get; set; }
        public bool BusSeatCol3Tv { get; set; }
        public int? BusSeatCol4Num { get; set; }
        public string BusSeatCol4Type { get; set; }
        public bool BusSeatCol4Tv { get; set; }
        public int? BusSeatCol5Num { get; set; }
        public string BusSeatCol5Type { get; set; }
        public bool BusSeatCol5Tv { get; set; }
        public int BusSeatRank { get; set; }
        public DateTime? BusSeatUpdated { get; set; }
        public DateTime BusSeatAdded { get; set; }

        public virtual Bus Bus { get; set; }
    }
}
