using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Ovo : AddAdicional
    {
        public Ovo(IPrato prato) : base(prato)
        {
        }

        public double GetPreco()
        {
            return prato.GetPreco() + 1.50d;
        }
    }
}
