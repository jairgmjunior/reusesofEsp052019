using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ClimaTempo : Observer
    {
        private decimal Temperatura;
        private decimal Pressao;
        private decimal Umidade;

        public void Update(decimal temperatura, decimal pressao, decimal umidade)
        {
            this.Temperatura = temperatura;
            this.Pressao = pressao;
            this.Umidade = umidade;
            Console.WriteLine($"{this.Temperatura},{this.Pressao}, {this.Umidade}");
        }
    }
}
