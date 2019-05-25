using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PratoB : IPrato
    {
        public double GetPreco()
        {
            return 12d;
        }
    }
}
