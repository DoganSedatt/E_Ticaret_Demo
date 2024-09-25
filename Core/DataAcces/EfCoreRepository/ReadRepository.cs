using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public DbSet<T> GetTable => throw new NotImplementedException();
    }
}
