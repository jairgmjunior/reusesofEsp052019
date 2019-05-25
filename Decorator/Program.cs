using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrato pratoA = new PratoA();
            IPrato pratoB = new PratoB();

            pratoA = new Ovo(pratoA);
            pratoB = new Ovo(pratoB);
            pratoA = new Cebola(pratoA);

            Console.WriteLine($"Prato A: {pratoA.GetPreco()}");
            Console.WriteLine($"Prato B: {pratoB.GetPreco()}");

            Console.ReadKey();
        }
    }
}
