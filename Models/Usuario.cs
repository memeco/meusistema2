using System;

namespace CadastroNotas.Models
{
    public class Usuarios
    {
        public int Senha { get; set; }
        public string Login { get; set; }

        public Usuarios(int senha, string login)
        {
            Senha = senha;
            Login = login;
        }

        public static Usuarios LoginUsuario()
        {
            Console.WriteLine("Favor insira seu login:");
            string login = Console.ReadLine();

            Console.WriteLine("Insira sua senha:");
            int senha = int.Parse(Console.ReadLine());

            return new Usuarios(senha, login);
        }
    }
}
