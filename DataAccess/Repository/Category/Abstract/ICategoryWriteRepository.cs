using Core.DataAcces;
using Core.DataAcces.EfCoreRepository;
using DataAccess.Context;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICategoryWriteRepository:IWriteRepository<Category>
    {

    }
}
