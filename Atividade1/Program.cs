namespace Atividade1
{
    internal class Program
    {
        static List<Aluno> listaAlunos = new List<Aluno>();

        static void Main(string[] args)
        {
            bool executando = true;

            while (executando)
            {
                Console.Clear();
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Alterar aluno");
                Console.WriteLine("4 - Remover aluno");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarAluno();
                        break;
                    case "2":
                        ListarAlunos();
                        break;
                    case "3":
                        AlterarAluno();
                        break;
                    case "4":
                        RemoverAluno();
                        break;
                    case "5":
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                if (executando)
                {
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadLine();
                }
            }
        }

        static void CadastrarAluno()
        {
            Console.Write("Digite o RA do aluno: ");
            string ra = Console.ReadLine();

            if (listaAlunos.Any(a => a.Ra == ra))
            {
                Console.WriteLine("Erro: Já existe um aluno com esse RA.");
                return;
            }

            Aluno aluno = new Aluno();
            aluno.Ra = ra;

            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Digite a idade do aluno: ");
            if (!int.TryParse(Console.ReadLine(), out int idade))
            {
                Console.WriteLine("Idade inválida.");
                return;
            }
            aluno.Idade = idade;

            listaAlunos.Add(aluno);
            Console.WriteLine("Aluno cadastrado com sucesso!");
        }

        static void ListarAlunos()
        {
            if (listaAlunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
                return;
            }

            Console.WriteLine("\nLista de alunos:");
            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine($"RA: {aluno.Ra} | Nome: {aluno.Nome} | Idade: {aluno.Idade}");
            }
        }

        static void AlterarAluno()
        {
            Console.Write("Digite o RA do aluno que deseja alterar: ");
            string ra = Console.ReadLine();

            var aluno = listaAlunos.FirstOrDefault(a => a.Ra == ra);
            if (aluno == null)
            {
                Console.WriteLine("Aluno não encontrado.");
                return;
            }

            Console.Write("Digite o novo nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Digite a nova idade do aluno: ");
            if (!int.TryParse(Console.ReadLine(), out int idade))
            {
                Console.WriteLine("Idade inválida.");
                return;
            }

            aluno.Idade = idade;

            Console.WriteLine("Aluno alterado com sucesso!");
        }

        static void RemoverAluno()
        {
            Console.Write("Digite o RA do aluno que deseja remover: ");
            string ra = Console.ReadLine();

            var aluno = listaAlunos.FirstOrDefault(a => a.Ra == ra);
            if (aluno == null)
            {
                Console.WriteLine("Aluno não encontrado.");
                return;
            }

            listaAlunos.Remove(aluno);
            Console.WriteLine("Aluno removido com sucesso!");
        }
    }
}
