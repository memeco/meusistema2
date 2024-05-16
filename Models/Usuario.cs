namespace ProgramaEscolar
{
    public class Usuarios
    {
        public string Professor{get; set;}
            public string Diretores{get; set;}
            public int Senha{get; set;}

        public Usuarios(string professor, string diretores, int senha){
            Professor = professor;
            Diretores = diretores;
            Senha = senha;
        }
    }
}