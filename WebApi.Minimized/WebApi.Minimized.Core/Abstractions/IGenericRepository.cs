using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApi.Minimized.Core.Abstractions
{
    public interface IGenericRepository
    {
        void Attach<T>(T t);
        T Add<T>(T entity) where T : class;
        T Find<T>(decimal id) where T : class;
        void Remove<T>(T entity) where T : class;
        IQueryable<T> Query<T>() where T : class;
        void SaveChanges();
    }
}
