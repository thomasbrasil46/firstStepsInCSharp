using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MeuMetodo();

            string nome = RetornaNome("Thomas", "Brasil");
            Console.WriteLine(nome);
        }
    
        static void MeuMetodo ()
        {
            Console.WriteLine("C# é legal");
        }

        static string RetornaNome(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }
    }
}
