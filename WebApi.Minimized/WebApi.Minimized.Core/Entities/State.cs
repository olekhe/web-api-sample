using System;
using System.Collections.Generic;
using WebApi.Minimized.Core.Entities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class State
    {
        public State()
        {
            Address = new HashSet<Address>();
            City = new HashSet<City>();
        }

        public decimal StateId { get; set; }
        public string StateAbrv { get; set; }
        public string StateName { get; set; }
        public int StateRank { get; set; }
        public string StateNameMl { get; set; }
        public bool? StateEnabled { get; set; }
        public decimal CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<City> City { get; set; }
    }
}
