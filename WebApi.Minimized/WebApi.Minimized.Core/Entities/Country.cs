using System;
using System.Collections.Generic;
using WebApi.Minimized.Core.Entities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Country
    {
        public Country()
        {
            Address = new HashSet<Address>();
            BusProgram = new HashSet<BusProgram>();
            City = new HashSet<City>();
            State = new HashSet<State>();
        }

        public decimal CountryId { get; set; }
        public string CountryAbrv { get; set; }
        public string CountryName { get; set; }
        public string CountryNameMl { get; set; }
        public bool? CountryEnabled { get; set; }
        public string CountryStateName { get; set; }
        public int CountryRank { get; set; }
        public string CountryStateNameMl { get; set; }
        public string CountryPostalCodeName { get; set; }
        public bool CountryStateRequired { get; set; }
        public string CountryPostalCodeNameRu { get; set; }
        public string CountryPostalCodeNameMl { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<BusProgram> BusProgram { get; set; }
        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<State> State { get; set; }
    }
}
