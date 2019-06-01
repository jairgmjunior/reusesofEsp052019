using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Entities
{
    public class Assinatura
    {
        IPreco preco;
        IContentTransformer contentTransformer;
        IPreparadorNumeroTransmissoes preparadorNumeroTransmissoes;

        public Assinatura (IPreco preco, IContentTransformer content, IPreparadorNumeroTransmissoes preparador)
        {
            this.preco = preco;
            this.contentTransformer = content;
            this.preparadorNumeroTransmissoes = preparador;
        }

        public decimal GetPreco()
        {
            return preco.GetCalculaPreco();
        }

        public string DisponibilizarConteudo()
        {
            return contentTransformer.ConverterQualidade();
        }

        public void PermitirNumeroTransmissoesSimultaneas()
        {
            var t = preparadorNumeroTransmissoes.PreparaAmbienteParaTransmissoesSimultaneas();
            Console.WriteLine($"Quantidade de Transmissoes: {t}");
        }      

    }
}
