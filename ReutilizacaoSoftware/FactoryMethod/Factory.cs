﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Factory
    {
        public abstract Veiculo CriarVeiculo(int quantidadePessoas, CondicaoMetereologica condicao);
    }
}
