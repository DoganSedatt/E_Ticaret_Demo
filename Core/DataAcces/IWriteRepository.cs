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

    }
}
