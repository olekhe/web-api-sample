using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.Minimized.Core.Entities;

namespace WebApi.Minimized.Services.Queries
{
    public static class ExcursionQueriesExtensions
    {
        public static IQueryable<Excursion> AllExcursion(this IQueryable<Excursion> query)
             => query
                 .Include(x => x.ExcursionId);
        public static IQueryable<Excursion> ExcursionDetails(this IQueryable<Excursion> query, decimal excursionId)
             => query
                .Where(x => x.ExcursionId == excursionId);
    }
}
