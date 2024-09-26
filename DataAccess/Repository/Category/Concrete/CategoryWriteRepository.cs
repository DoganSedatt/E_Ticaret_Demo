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
    public class CategoryWriteRepository : WriteRepository<Category, E_Ticaret_Context>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(E_Ticaret_Context context) : base(context)
        {
        }
    }
}
