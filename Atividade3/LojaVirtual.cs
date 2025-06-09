using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    class LojaVirtual
    {
        public void RealizarPagamento(IPagamento metodoPagamento, decimal valor)
        {
            metodoPagamento.ProcessarPagamento(valor);
        }
    }

}
