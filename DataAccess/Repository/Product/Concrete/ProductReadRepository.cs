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
    public class ProductReadRepository : ReadRepository<Product, E_Ticaret_Context>, IProductReadRepository
    {
        public ProductReadRepository(E_Ticaret_Context context) : base(context)
        {

        }
    }
}
