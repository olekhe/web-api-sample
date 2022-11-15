using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.Minimized.Core.Entities;

namespace WebApi.Minimized.Services.Queries
{
    public static class CityQueriesExtensions
    {
        public static IQueryable<City> AllCities(this IQueryable<City> query)
             => query
                 .Include(x => x.BusCity);
    }
}
