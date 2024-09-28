using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes
{
    public class AddRangeCategoryRequest
    {
        public IEnumerable<string> CategoryNames { get; set; }
    }
}
