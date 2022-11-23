using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.Minimized.Core.Entities;

namespace WebApi.Minimized.Services.Queries
{
    public static class NewsQueriesExtensions
    {
        public static IQueryable<News> AllNews(this IQueryable<News> query)
             => query
                 .Include(x => x.NewsId);
    }
}
