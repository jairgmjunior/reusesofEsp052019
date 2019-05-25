using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var veiculo = new ConcreteFactory().CriarVeiculo(1, CondicaoMetereologica.CHUVA);
            Console.WriteLine(veiculo.GetType().Name);
            veiculo.Imprimir();


            Console.ReadKey();
        }
    }
}
