using System;
using Atividade3;

public class Program
{
    public static void Main(string[] args)
    {
        IPagamento pagamento;
        int opcao;
        Console.WriteLine("Qual a forma de pagamento? \n1. Boleto \n2.Cartão de crédito");

        string? input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            opcao = int.Parse(input);

            if (opcao == 1)
            {
                pagamento = new PagamentoBoleto();
            }
            else
            {
                pagamento = new PagamentoCartaoCredito();
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        Console.ReadKey();
    }
}

