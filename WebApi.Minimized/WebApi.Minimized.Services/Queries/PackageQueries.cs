using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.Minimized.Core.Entities;

namespace WebApi.Minimized.Services.Queries
{
    public static class PackageQueriesExtensions
    {
        public static IQueryable<Package> AllPackages(this IQueryable<Package> query)
             => query
                 .Include(x => x.PackageId);
    }

    public static class PackageByCategoryQueriesExtensions
    {
        public static IQueryable<Package> CategoryPackages(this IQueryable<Package> query, int categoryPackageId)
             => query
                 .Where(x => x.DestId == categoryPackageId);
    }

    public static class PackageDetailsQueriesExtensions
    {
        public static IQueryable<Package> DetailsPackage(this IQueryable<Package> query, int packageId)
             => query
                 .Where(x => x.PackageId == packageId);
    }
}
