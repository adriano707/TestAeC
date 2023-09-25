using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain.Entities.Repository
{
    public interface IRepository
    {
        IQueryable<T> Query<T>() where T : class;
        Task<T> InsertAsync<T>(T entity) where T : class;
        T Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        void SaveChanges();
        Task SaveChangeAsync();
    }
}
