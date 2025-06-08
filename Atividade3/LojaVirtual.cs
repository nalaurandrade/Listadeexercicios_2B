using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    internal class LojaVirtual : IPagamento
    {
        public double valor { get; set; }

        public void ProcessarPagamento(double valor)
        {

        }
    }
}
