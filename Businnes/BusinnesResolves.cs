using Businnes.Concrete;
using DataAccess.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes
{
    public static class BusinnesResolves
    {
        public static void GetBusinnesResolves(this IServiceCollection services)
        {
            services.AddScoped<ICategoryWriteService, CategoryWriteManager>();
            
        }
    }
}
