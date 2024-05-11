using System;
using System.Collections.Generic;

namespace CadastroNotas.Models
{
    public class Aluno
    {
        public string Nome { get; set; }
        public List<Materia> Materias { get; set; }

        public Aluno(string nome)
        {
            Nome = nome;
            Materias = new List<Materia>();
        }

        public void AdicionarMateria(string nomeMateria, double nota1, double nota2)
        {
            Materias.Add(new Materia(nomeMateria, nota1, nota2));
        }

        public void AdicionarRecuperacao(string nomeMateria, double notaRecuperacao)
        {
            foreach (var materia in Materias)
            {
                if (materia.Nome == nomeMateria)
                {
                    materia.NotaRecuperacao = notaRecuperacao;
                    break;
                }
            }
        }

        public List<string> CalcularStatusMaterias()
        {
            List<string> statusMaterias = new List<string>();

            foreach (var materia in Materias)
            {
                double media = (materia.Nota1 + materia.Nota2) / 2;

                if (media >= 7.0)
                {
                    statusMaterias.Add($"{materia.Nome}: Aprovado com média {media.ToString("F2")}");
                }
                else
                {
                    if (materia.NotaRecuperacao != null && (media + materia.NotaRecuperacao) / 2 >= 5.0)
                    {
                        statusMaterias.Add($"{materia.Nome}: Aprovado após recuperação com média {(media + materia.NotaRecuperacao) / 2:F2}");
                    }
                    else
                    {
                        statusMaterias.Add($"{materia.Nome}: Reprovado com média {media.ToString("F2")}");
                    }
                }
            }

            return statusMaterias;
        }
    }

    public class Materia
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double? NotaRecuperacao { get; set; }

        public Materia(string nome, double nota1, double nota2)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            NotaRecuperacao = null;
        }
    }
}
