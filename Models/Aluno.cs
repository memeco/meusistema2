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
        public string CalcularMedia()
        {
            double media = (Nota1 + Nota2) / 2;

            if (media >= 7.0)
            {
                return "Aprovado com média " + media.ToString("F2");
            }
            else
            {
                return "Reprovado com média " + media.ToString("F2");
            }
        }
    }
}