using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    interface IPagamento
    {
        double valor {  get; set; }
        void ProcessarPagamento(double valor);
    }
}
