using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Cebola : AddAdicional
    {
        public Cebola(IPrato prato) : base(prato)
        {
        }

        public double GetPreco()
        {
            return base.GetPreco() + 1;
        }
    }
}
