using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class ChflightSeat
    {
        public ChflightSeat()
        {
            InverseParentChflightSeat = new HashSet<ChflightSeat>();
            ReqPassportChflightSeatBack = new HashSet<ReqPassport>();
            ReqPassportChflightSeatThere = new HashSet<ReqPassport>();
        }

        public decimal ChflightSeatId { get; set; }
        public decimal? ParentChflightSeatId { get; set; }
        public decimal ChflightId { get; set; }
        public int ChflightSeatType { get; set; }
        public int ChflightSeatStatus { get; set; }
        public string ChflightSeatNote { get; set; }
        public DateTime? ChflightSeatUpdated { get; set; }
        public DateTime ChflightSeatAdded { get; set; }

        public virtual Chflight Chflight { get; set; }
        public virtual ChflightSeat ParentChflightSeat { get; set; }
        public virtual ICollection<ChflightSeat> InverseParentChflightSeat { get; set; }
        public virtual ICollection<ReqPassport> ReqPassportChflightSeatBack { get; set; }
        public virtual ICollection<ReqPassport> ReqPassportChflightSeatThere { get; set; }
    }
}
