using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Entities
{
    public enum TipoAssinatura
    {
        Hd,
        SIMPLES,
        ULTRAHD
    }

    public class Streaming
    {
        TipoAssinatura tipoAssinatura;
        

        public Streaming(TipoAssinatura tipoAssinatura)
        {
            this.tipoAssinatura = tipoAssinatura;
        }

        

        public decimal GetCalculaPreco()
        {
            if(tipoAssinatura == TipoAssinatura.SIMPLES)
            {
                return new decimal(21.9);
            }

            return 0;
        }
    }
}
