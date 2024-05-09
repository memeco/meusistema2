using System;
using CadastroNotas.Controllers;
using CadastroNotas.Views;

namespace CadastroNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new AlunoController();

            while (true)
            {
                View.ExibirMenu();
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Nome do aluno: ");
                        string nome = Console.ReadLine();
                        Console.Write("Nota 1: ");
                        double nota1 = double.Parse(Console.ReadLine());
                        Console.Write("Nota 2: ");
                        double nota2 = double.Parse(Console.ReadLine());
                        controller.CadastrarAluno(nome, nota1, nota2);
                        break;
                    case "2":
                        View.LimparTela();
                        View.ExibirBoletim(controller);
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                View.LimparTela();
            }
        }
    }
}
