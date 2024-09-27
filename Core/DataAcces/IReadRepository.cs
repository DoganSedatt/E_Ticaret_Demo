using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAcces
{
    public interface IReadRepository<T>:IRepository<T> where T : BaseEntity<Guid>
    {
        //Veritabanından yapılacak sorguları temsil eden generic interface 
        IQueryable<T> GetAll();//Tüm verileri çekecek metod
        IQueryable<T> GetWhere(Expression<Func<T,bool>> predicate);//Şarta bağlı verileri çekecek metod
        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate);//Şarta bağlı tek veri getirecek metod
        Task<T> GetByIdAsync(Guid id);//Id'ye göre veri getirecek metod
    }
}
