using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class AddAdicional : IPrato
    {
        public readonly IPrato prato;

        public AddAdicional(IPrato prato)
        {
            this.prato = prato;
        }

        public double GetPreco()
        {
            return prato.GetPreco();
        }
    }
}
