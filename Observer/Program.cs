using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {

        static void Main(string[] args)
        {
            var estacao = new EstacaoMetereologica();

            var immet = new Immet();
            var clima = new ClimaTempo();
            var campus = new Campus();

            estacao.addObserver(immet);
            estacao.addObserver(clima);
            estacao.addObserver(campus);           

            estacao.SetMedicoes(1, 2, 3);


            Console.ReadKey();
        }
    }

    
}
