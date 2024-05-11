using System;
using System.Collections.Generic;
using CadastroNotas.Models;

namespace CadastroNotas.Controllers
{
    public class AlunoController
    {
        private Aluno aluno;

        public void CriarAluno(string nome, double nota1, double nota2)
        {
            aluno = new Aluno(nome);
            aluno.AdicionarMateria("Português", nota1, nota2);
            aluno.AdicionarMateria("Matemática", nota1, nota2);
        }

        public void AdicionarNotas(double nota1, double nota2)
        {
            if (aluno == null)
            {
                Console.WriteLine("Por favor, crie um aluno antes de adicionar notas.");
                return;
            }

            aluno.AdicionarMateria("Matéria", nota1, nota2);
        }

        public void MostrarBoletim()
        {
            if (aluno == null)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
                return;
            }

            var statusMaterias = aluno.CalcularStatusMaterias();
            foreach (var status in statusMaterias)
            {
                Console.WriteLine(status);
            }
        }
    }
}
