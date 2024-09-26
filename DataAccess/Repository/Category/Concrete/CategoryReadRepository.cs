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
    public class CategoryReadRepository : ReadRepository<Category, E_Ticaret_Context>, ICategoryReadRepository
    {
        public CategoryReadRepository(E_Ticaret_Context context) : base(context)
        {
        }
    }
}
