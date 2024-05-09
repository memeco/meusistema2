using System;
using System.Collections.Generic;
using CadastroNotas.Models;

namespace CadastroNotas.Controllers
{
    public class AlunoController
    {
        //campo privado para armazenar a lista de objetos 'Aluno' 
        private List<Aluno> alunos;

        //construtor que inicializa a lista de alunos
        public AlunoController()
        {
            alunos = new List<Aluno>();
        }

        //método público que permite cadastrar um novo aluno na lista
        public void CadastrarAluno(string nome, double nota1, double nota2)
        {
            alunos.Add(new Aluno(nome, nota1, nota2));
        }

        public void MostrarBoletim(){
            Console.WriteLine("===Boletim===");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}");
                Console.WriteLine($"Nota 1: {aluno.Nota1}");
                Console.WriteLine($"Nota 2: {aluno.Nota2}");
                Console.WriteLine($"Média: {aluno.CalcularMedia()}");
                Console.WriteLine("====================");
            }
        }
    }
}