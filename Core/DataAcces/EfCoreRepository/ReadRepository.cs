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
        //T entity'sinin tablo bilgisini alır

        public IQueryable<T> GetAll()
            => GetTable;
        //Tüm veriyi çeker 
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate)
            => GetTable.Where(predicate);
        //Verilen şarta uygun verileri çeker
        public async Task<T> GetByIdAsync(string id)
            => await GetTable.FindAsync(Guid.Parse(id));
        //Verilen id'ye uygun veriyi getirir
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
            => await GetTable.FirstOrDefaultAsync(predicate);
        //Verilen şarta uygun tek bir veriyi getirir
        
    }
}
