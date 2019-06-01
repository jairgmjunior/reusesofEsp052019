using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Entities
{
    public class PrecoHd : IPreco
    {
        public decimal GetCalculaPreco()
        {
            return new decimal(32.9);
        }
    }
}
