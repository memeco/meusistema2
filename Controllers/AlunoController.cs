using System;
using CadastroNotas.Models;

namespace CadastroNotas.Controllers
{
    public class AlunoController
    {
        private Aluno aluno;

        public void CadastrarAluno(string nome, double nota1Portugues, double nota2Portugues, double nota1Matematica, double nota2Matematica)
        {
            aluno = new Aluno(nome)
            {
                Nota1Portugues = nota1Portugues,
                Nota2Portugues = nota2Portugues,
                Nota1Matematica = nota1Matematica,
                Nota2Matematica = nota2Matematica
            };

            Console.WriteLine($"Aluno {aluno.Nome} cadastrado com sucesso!");
        }

        public void MostrarBoletim()
        {
            if (aluno == null)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
                return;
            }

            Console.WriteLine($"===== Boletim do Aluno {aluno.Nome} =====");
            Console.WriteLine("Português:");
            Console.WriteLine($"Nota 1: {aluno.Nota1Portugues}, Nota 2: {aluno.Nota2Portugues}, Média: {aluno.CalcularMediaPortugues()}, Situação: {aluno.SituacaoPortugues()}");
            Console.WriteLine("Matemática:");
            Console.WriteLine($"Nota 1: {aluno.Nota1Matematica}, Nota 2: {aluno.Nota2Matematica}, Média: {aluno.CalcularMediaMatematica()}, Situação: {aluno.SituacaoMatematica()}");
            Console.WriteLine("====================");
        }
    }
}
