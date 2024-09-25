using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAcces
{
    public interface IRepository<T> where T : BaseEntity<Guid>
    {
        DbSet<T> GetTable {  get; }
    }
}
