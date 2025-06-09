using Atividade3;

class Program
{
    static void Main(string[] args)
    {
        LojaVirtual loja = new LojaVirtual();

        Console.WriteLine("Bem-vindo à Loja Virtual!");

        Console.Write("Digite o valor do pagamento: R$ ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
        {
            Console.WriteLine("Valor inválido.");
            return;
        }

        Console.WriteLine("\nEscolha o método de pagamento:");
        Console.WriteLine("1 - Boleto Bancário");
        Console.WriteLine("2 - Cartão de Crédito");
        Console.WriteLine("3 - PIX");

        Console.Write("Opção: ");
        string opcao = Console.ReadLine();

        IPagamento metodoPagamento = null;

        switch (opcao)
        {
            case "1":
                metodoPagamento = new PagamentoBoleto();
                break;
            case "2":
                metodoPagamento = new PagamentoCartaoCredito();
                break;
            case "3":
                metodoPagamento = new PagamentoPix();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                return;
        }

        loja.RealizarPagamento(metodoPagamento, valor);
    }
}
