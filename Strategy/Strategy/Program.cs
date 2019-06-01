using Strategy.Entities;
using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var preco = new PrecoSimples();
            var content = new Hd();
            var preparador = new TransmissaoUnica();

            var assinatura = new Assinatura(preco, content, preparador);
            Console.WriteLine($"Conteudo disponibilizado: {assinatura.DisponibilizarConteudo()}");
            Console.WriteLine($"Valor: {assinatura.GetPreco()}");
            assinatura.PermitirNumeroTransmissoesSimultaneas();

            Console.ReadKey();

        }
    }
}
