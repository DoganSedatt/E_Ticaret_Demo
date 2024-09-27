using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
        //T entity'sinin tablo bilgisini alır
        public async Task<bool> AddAsync(T entity)
        {
            entity.CreatedDate = DateTime.UtcNow;
            EntityEntry<T> entry = await GetTable.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entry.State == EntityState.Added;
            //Verilen entity'i ekle ve durumunun added olup olmadığını dön
        }

        public async Task<bool> AddAsyncRange(IEnumerable<T> entities)
        {
            await GetTable.AddRangeAsync(entities);
            return true;
        }

        public async Task<bool> DeleteWithIdAsync(Guid id, bool softDelete=true)
        {
            T? entity = await GetTable.FirstOrDefaultAsync(entity => entity.Id == id);
            if(softDelete)
            entity.DeletedDate = DateTime.UtcNow;

            return DeleteWithModelAsync(entity);

        }

        public bool DeleteWithModelAsync(T entity)
        {
           EntityEntry<T> entry= GetTable.Remove(entity);
            entity.DeletedDate = DateTime.UtcNow;
           _context.SaveChanges();
           return entry.State == EntityState.Deleted;
        }

        public bool Update(T entity)
        {
           EntityEntry<T> entry= GetTable.Update(entity);
            entity.UpdatedDate = DateTime.UtcNow;
            _context.SaveChanges();
            return entry.State == EntityState.Modified;

        }
    }
}
