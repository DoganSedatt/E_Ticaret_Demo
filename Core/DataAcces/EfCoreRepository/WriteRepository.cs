using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAcces.EfCoreRepository
{
    public class WriteRepository<T, TContext> : IRepository<T>
        where T : BaseEntity<Guid>,
        new() where TContext : DbContext
    {
        private readonly TContext _context;

        public WriteRepository(TContext context)
        {
            _context = context;
        }

        public DbSet<T> GetTable => throw new NotImplementedException();
    }
}
