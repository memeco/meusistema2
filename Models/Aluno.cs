using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroNotas.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        public string NomeCompleto {get; private set;}
        public string Matricula { get; private set; }
        public string Senha { get; private set; }
        private List<String> Disciplinas { get; set; } = new List<String>();
        public int Presenca { get; private set; }

        public Aluno(string nomeCompleto, string matricula, string senha, int presenca)
        {
            NomeCompleto = nomeCompleto;
            Matricula = matricula;
            Senha = senha;
            Presenca = presenca;
        }


        // Método para adicionar disciplinas
        public void AdicionarDisciplina(string disciplina)
        {
            Disciplinas.Add(disciplina);
        }


    }
}
