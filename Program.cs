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
                        Console.WriteLine("Digite a nota 1 de Português:");
                        double nota1Portugues = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a nota 2 de Português:");
                        double nota2Portugues = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a nota 1 de Matemática:");
                        double nota1Matematica = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a nota 2 de Matemática:");
                        double nota2Matematica = Convert.ToDouble(Console.ReadLine());

                        controller.CadastrarAluno(nomeAluno, nota1Portugues, nota2Portugues, nota1Matematica, nota2Matematica);
                        break;
                    case "2":
                        View.LimparTela();
                        controller.MostrarBoletim();
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
