using System;
using System.Collections.Generic;
using WebApi.Minimized.Core.Entities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class City
    {
        public City()
        {
            BusCity = new HashSet<BusCity>();
            BusRouteCityIdfromNavigation = new HashSet<BusRoute>();
            BusRouteCityIdtoNavigation = new HashSet<BusRoute>();
            BusTripSeatCityIdfrom1Navigation = new HashSet<BusTripSeat>();
            BusTripSeatCityIdfrom2Navigation = new HashSet<BusTripSeat>();
            BusTripSeatCityIdfrom3Navigation = new HashSet<BusTripSeat>();
            BusTripSeatCityIdfrom4Navigation = new HashSet<BusTripSeat>();
            BusTripSeatCityIdfrom5Navigation = new HashSet<BusTripSeat>();
            BusTripSeatCityIdto1Navigation = new HashSet<BusTripSeat>();
            BusTripSeatCityIdto2Navigation = new HashSet<BusTripSeat>();
            BusTripSeatCityIdto3Navigation = new HashSet<BusTripSeat>();
            BusTripSeatCityIdto4Navigation = new HashSet<BusTripSeat>();
            BusTripSeatCityIdto5Navigation = new HashSet<BusTripSeat>();
        }

        public decimal CityId { get; set; }
        public decimal CountryId { get; set; }
        public decimal? StateId { get; set; }
        public string CityName { get; set; }
        public string CityNameMl { get; set; }
        public bool? CityEnabled { get; set; }
        public int CityRank { get; set; }

        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<BusCity> BusCity { get; set; }
        public virtual ICollection<BusRoute> BusRouteCityIdfromNavigation { get; set; }
        public virtual ICollection<BusRoute> BusRouteCityIdtoNavigation { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeatCityIdfrom1Navigation { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeatCityIdfrom2Navigation { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeatCityIdfrom3Navigation { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeatCityIdfrom4Navigation { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeatCityIdfrom5Navigation { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeatCityIdto1Navigation { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeatCityIdto2Navigation { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeatCityIdto3Navigation { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeatCityIdto4Navigation { get; set; }
        public virtual ICollection<BusTripSeat> BusTripSeatCityIdto5Navigation { get; set; }
    }
}
