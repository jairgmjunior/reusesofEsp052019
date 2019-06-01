using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Entities
{
    public class Simples : IContentTransformer
    {
        public string ConverterQualidade()
        {
            return "Simples";
        }
    }
}
