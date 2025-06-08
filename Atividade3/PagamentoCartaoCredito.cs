using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    class PagamentoCartaoCredito : IPagamento
    {
        public double valor { get; set; }

        void IPagamento.ProcessarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento de R${valor} processado no cartão de crédito");
        }
    }

}


