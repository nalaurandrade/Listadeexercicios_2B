using System;
using System.Collections.Generic;
using System.Linq;

namespace Atividade2
{
    internal class Produto
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public override string ToString()
        {
            return $"Descrição: {Descricao}, Valor: R${Valor:F2}";
        }
    }
}

    