namespace Atividade2
{
    internal class Program
    {
        static List<Produto> produtos = new List<Produto>();

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Remover Produto");
                Console.WriteLine("3 - Pesquisar Produto");
                Console.WriteLine("4 - Mostrar Produto com Menor Valor");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                if (!int.TryParse(Console.ReadLine(), out opcao)) opcao = 0;

                switch (opcao)
                {
                    case 1:
                        CadastrarProduto();
                        break;
                    case 2:
                        RemoverProduto();
                        break;
                    case 3:
                        PesquisarProduto();
                        break;
                    case 4:
                        MostrarProdutoMenorValor();
                        break;
                    case 5:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (opcao != 5);
        }

        static void CadastrarProduto()
        {
            Console.Write("Digite a descrição do produto: ");
            string descricao = Console.ReadLine();

            Console.Write("Digite o valor do produto: ");
            if (double.TryParse(Console.ReadLine(), out double valor))
            {
                produtos.Add(new Produto { Descricao = descricao, Valor = valor });
                Console.WriteLine("Produto cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }

        static void RemoverProduto()
        {
            Console.Write("Digite a descrição do produto que deseja remover: ");
            string descricao = Console.ReadLine();

            Produto produtoRemover = produtos.FirstOrDefault(p => p.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));

            if (produtoRemover != null)
            {
                produtos.Remove(produtoRemover);
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        static void PesquisarProduto()
        {
            Console.Write("Digite a descrição do produto que deseja pesquisar: ");
            string descricao = Console.ReadLine();

            Produto produtoEncontrado = produtos.FirstOrDefault(p => p.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));

            if (produtoEncontrado != null)
            {
                Console.WriteLine("Produto encontrado:");
                Console.WriteLine(produtoEncontrado);
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        static void MostrarProdutoMenorValor()
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }

            Produto menor = produtos.OrderBy(p => p.Valor).First();
            Console.WriteLine("Produto com menor valor:");
            Console.WriteLine(menor);
        }
    }
}


