﻿using Atomic.Test.AeC.Domain.Repositories;

namespace Atomic.TestAeC.Data.REpository
{
    public class Repository : IRepository
    {
        private readonly TestAeCDbContext _context;

        public Repository(TestAeCDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Query<T>() where T : class
        {
            return _context.Set<T>().AsQueryable();
        }

        public async Task<T> InsertAsync<T>(T entity) where T : class
        {
            await _context.Set<T>().AddAsync(entity);

            return entity;
        }

        public T Update<T>(T entity) where T : class
        {
            _context.Set<T>().Update(entity);

            return entity;
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Set<T>().Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
