using System;

namespace ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            //ciclo for que lê e mostra no ecrã o array de argumentos dados 
            //pelo utilizador no git bash, numerando-os do primeiro ao último
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argumento {i + 1}: {args[i]}");
            }

            Console.Read();//ReadKey não funciona no git bash, usar o Read
        }
    }
}
