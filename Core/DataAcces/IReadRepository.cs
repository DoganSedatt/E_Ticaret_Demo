using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAcces
{
    public interface IReadRepository<T>:IRepository<T> where T : BaseEntity<Guid>
    {
        //Veritabanından yapılacak sorguları temsil eden generic interface 
    }
}
