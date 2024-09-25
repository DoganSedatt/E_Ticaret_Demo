using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAcces.EfCoreRepository
{
    public class ReadRepository<T, TContext> : IReadRepository<T>
    where T : BaseEntity<Guid>,
    new() where TContext : DbContext
    {
        private readonly TContext _context;

        public ReadRepository(TContext context)
        {
            _context = context;
        }

        public DbSet<T> GetTable => _context.Set<T>();

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
