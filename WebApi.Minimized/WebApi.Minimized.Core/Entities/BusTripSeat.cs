using System;
using System.Collections.Generic;
using WebApi.Minimized.Core.Entities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class BusTripSeat
    {
        public decimal BusTripSeatId { get; set; }
        public decimal BusTripId { get; set; }
        public int BusTripSeatFloor { get; set; }
        public int BusTripSeatRow { get; set; }
        public decimal? ReqPassportId1 { get; set; }
        public decimal? CityIdfrom1 { get; set; }
        public decimal? CityIdto1 { get; set; }
        public int? BusTripSeatCol1Num { get; set; }
        public string BusTripSeatCol1Type { get; set; }
        public bool BusTripSeatCol1Tv { get; set; }
        public string BusTripSeatCol1Note { get; set; }
        public decimal? ReqPassportId2 { get; set; }
        public decimal? CityIdfrom2 { get; set; }
        public decimal? CityIdto2 { get; set; }
        public int? BusTripSeatCol2Num { get; set; }
        public string BusTripSeatCol2Type { get; set; }
        public bool BusTripSeatCol2Tv { get; set; }
        public decimal? ReqPassportId3 { get; set; }
        public decimal? CityIdfrom3 { get; set; }
        public decimal? CityIdto3 { get; set; }
        public int? BusTripSeatCol3Num { get; set; }
        public string BusTripSeatCol2Note { get; set; }
        public string BusTripSeatCol3Type { get; set; }
        public bool BusTripSeatCol3Tv { get; set; }
        public string BusTripSeatCol3Note { get; set; }
        public decimal? ReqPassportId4 { get; set; }
        public decimal? CityIdfrom4 { get; set; }
        public decimal? CityIdto4 { get; set; }
        public int? BusTripSeatCol4Num { get; set; }
        public string BusTripSeatCol4Type { get; set; }
        public bool BusTripSeatCol4Tv { get; set; }
        public string BusTripSeatCol4Note { get; set; }
        public decimal? ReqPassportId5 { get; set; }
        public decimal? CityIdfrom5 { get; set; }
        public decimal? CityIdto5 { get; set; }
        public int? BusTripSeatCol5Num { get; set; }
        public string BusTripSeatCol5Type { get; set; }
        public bool BusTripSeatCol5Tv { get; set; }
        public string BusTripSeatCol5Note { get; set; }
        public int BusTripSeatRank { get; set; }
        public DateTime? BusTripSeatUpdated { get; set; }
        public DateTime BusTripSeatAdded { get; set; }

        public virtual BusTrip BusTrip { get; set; }
        public virtual City CityIdfrom1Navigation { get; set; }
        public virtual City CityIdfrom2Navigation { get; set; }
        public virtual City CityIdfrom3Navigation { get; set; }
        public virtual City CityIdfrom4Navigation { get; set; }
        public virtual City CityIdfrom5Navigation { get; set; }
        public virtual City CityIdto1Navigation { get; set; }
        public virtual City CityIdto2Navigation { get; set; }
        public virtual City CityIdto3Navigation { get; set; }
        public virtual City CityIdto4Navigation { get; set; }
        public virtual City CityIdto5Navigation { get; set; }
        public virtual ReqPassport ReqPassportId1Navigation { get; set; }
        public virtual ReqPassport ReqPassportId2Navigation { get; set; }
        public virtual ReqPassport ReqPassportId3Navigation { get; set; }
        public virtual ReqPassport ReqPassportId4Navigation { get; set; }
        public virtual ReqPassport ReqPassportId5Navigation { get; set; }
    }
}
