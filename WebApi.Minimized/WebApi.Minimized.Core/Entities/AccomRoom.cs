using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class AccomRoom
    {
        public decimal AccomRoomId { get; set; }
        public decimal AccomId { get; set; }
        public string AccomRoomBoard { get; set; }
        public string AccomRoomBoardCode { get; set; }
        public string AccomRoomRoom { get; set; }
        public string AccomRoomRoomCode { get; set; }
        public int? AccomRoomAdults { get; set; }
        public int? AccomRoomChildren { get; set; }
        public int? AccomRoomInfants { get; set; }
        public string AccomRoomChildAges { get; set; }
        public decimal AccomRoomTotalCost { get; set; }
        public decimal AccomRoomNetCost { get; set; }
        public string AccomRoomNote { get; set; }
        public DateTime AccomRoomAdded { get; set; }
        public string AccomRoomLeadName { get; set; }

        public virtual Accom Accom { get; set; }
    }
}
