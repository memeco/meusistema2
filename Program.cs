using System;
using CadastroNotas.Controllers;
using CadastroNotas.Views;

namespace CadastroNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoController controller = new AlunoController();

            bool sair = false;
            while (!sair)
            {
                View.ExibirMenu();
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        View.LimparTela();
                        Console.WriteLine("Digite o nome do aluno:");
                        string nomeAluno = Console.ReadLine();
                        Console.WriteLine("Digite as notas para o aluno (Nota1 Nota2):");
                        string[] notas = Console.ReadLine().Split(' ');

                        if (notas.Length != 2)
                        {
                            Console.WriteLine("Por favor, insira duas notas separadas por espaço.");
                            break;
                        }

                        double nota1, nota2;

                        if (!double.TryParse(notas[0], out nota1) || !double.TryParse(notas[1], out nota2))
                        {
                            Console.WriteLine("Por favor, insira notas válidas.");
                            break;
                        }

                        controller.CriarAluno(nomeAluno, nota1, nota2);
                        Console.WriteLine("Aluno cadastrado com sucesso!");
                        break;
                    case "2":
                        View.LimparTela();
                        View.ExibirBoletim(controller);
                        break;
                    case "3":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                View.LimparTela();
            }
        }
    }
}
