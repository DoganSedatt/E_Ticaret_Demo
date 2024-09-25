using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class E_Ticaret_Context : DbContext
    {
        public E_Ticaret_Context(DbContextOptions options) : base(options)
        {

        }
    }
}
