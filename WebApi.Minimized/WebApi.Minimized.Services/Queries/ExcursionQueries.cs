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
                 .Include(x => x.PkgExtra);
        public static IQueryable<Excursion> ExcursionDetails(this IQueryable<Excursion> query, decimal excursionId)
             => query
                .Include(x => x.PkgExtra.Select(y => y.Extra))
                .Where(x => x.ExcursionId == excursionId);
    }
}
