using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAcces.EfCoreRepository
{
    public class WriteRepository<T, TContext> : IWriteRepository<T>
        where T : BaseEntity<Guid>,
        new() where TContext : DbContext
    {
        private readonly TContext _context;

        public WriteRepository(TContext context)
        {
            _context = context;
        }

        public DbSet<T> GetTable => _context.Set<T>();

        public Task<bool> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddAsyncRange(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public bool DeleteWithIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteWithModelAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
