using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Tesla : Veiculo
    {
        public override void Imprimir()
        {
            Console.WriteLine("Tesla");
        }
    }
}
