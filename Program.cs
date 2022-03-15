//importacoes
using System;

//divisoes logicas
namespace MeuApp
{
    //programa
    class Program
    {
                    //metodo
        static void Main(string[] args)
        {
            int inteiro = 100;
            float real = 25.8f;

            //real = inteiro;
            //inteiro = (int)real;
            //string valorReal = real.ToString();
            //inteiro = int.Parse(valorReal);
            inteiro = Convert.ToInt32(real);

            ///Console.WriteLine(valorReal);
            Console.WriteLine(inteiro);
            Console.WriteLine(Convert.ToBoolean(1));
        }
    }
}
