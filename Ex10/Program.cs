using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variáveis
            string s;

            //pedir uma frase ao utilizador
            Console.WriteLine("Insere uma frase:");
            //guardar a frase inserida na string s
            s =Console.ReadLine();
            //mostrar a string s no ecrã
            Console.WriteLine($"\nFrase inserida: {s}");

            Console.ReadKey();
        }
    }
}
