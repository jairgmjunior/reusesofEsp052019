using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ConcreteFactory : Factory
    {
        public override Veiculo CriarVeiculo(int quantidadePessoas, CondicaoMetereologica condicao)
        {
            if (quantidadePessoas <= 2)
            {
                return new Tesla();

            }
            else if (quantidadePessoas <= 5 && condicao == CondicaoMetereologica.SOL)
            {
                return new Escort();

            }
            else if (quantidadePessoas <= 5 && condicao == CondicaoMetereologica.CHUVA)
            {
                return new Opala();
            }
            else if (quantidadePessoas > 5 && quantidadePessoas < 20)
            {
                return new Besta();
            }

            return null;
        }
    }
}
