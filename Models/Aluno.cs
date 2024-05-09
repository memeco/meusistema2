using System;

namespace CadastroNotas.Models
{
    public class Aluno
    {
        //declaração de propriedades
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }

        //criação do método construtor
        public Aluno(string nome, double nota1, double nota2)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
        }

        //criação da função de média
        public double CalcularMedia()
        {
            return (Nota1 + Nota2) / 2;
        }
    }
}