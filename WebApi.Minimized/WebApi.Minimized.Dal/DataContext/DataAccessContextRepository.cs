using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApi.Minimized.Core.Abstractions;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Dal.DataContext
{
    public class DataAccessContextRepository : IGenericRepository
    {
        protected readonly JohnyDavDataAccess _context;

        public DataAccessContextRepository(JohnyDavDataAccess context)
        {
            _context = context;
        }

        public void Attach<T>(T t)
            => _context.Attach(t);

        public T Add<T>(T entity) where T : class =>
            _context.Set<T>().Add(entity).Entity;

        public T Find<T>(decimal id) where T : class
            => _context.Set<T>().Find(id);

        public IQueryable<T> Query<T>() where T : class =>
            _context.Set<T>().AsNoTracking();

        public void Remove<T>(T entity) where T : class
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange<T>(IEnumerable<T> entities) where T : class
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public void SaveChanges() =>
            _context.SaveChanges();
    }
}
