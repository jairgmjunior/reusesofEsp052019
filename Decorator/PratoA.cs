using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PratoA : IPrato
    {
        public double GetPreco()
        {
            return 10d;
        }
    }
}
