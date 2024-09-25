using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAcces
{
    public interface IWriteRepository<T>:IRepository<T> where T : BaseEntity<Guid>
    {
        //Veritabanına yapılacak insert,update ve delete işlemlerini temsil eden generic interface
        Task<bool> AddAsync(T entity);//Tek veri ekleyecek metod
        Task<bool> AddAsyncRange(List<T> entities);//Çok veri ekleyecek metod
        bool Update(T entity);//Veri güncelleme metodu
        Task<bool> DeleteWithIdAsync(string id, bool softDelete=true);//Id ile veri silen metod
        bool DeleteWithModelAsync(T entity);//Verilen model ile veri silen metod 

    }
}
