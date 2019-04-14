using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variáveis
            string s;

            //pedir uma frase ao utilizador p/ ser invertida
            Console.WriteLine("Insere uma frase para ser invertida:");

            //guardar a frase inserida na string s
            s = Console.ReadLine();

            //mostrar a string s ao contrário no ecrã
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);

            }
            Console.ReadKey();
        }
    }
}
