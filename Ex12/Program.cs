using System;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variáveis
            int a, b;

            //pedir ao utilizador dois nums inteiros para somar
            Console.WriteLine("Insere dois números inteiros para somar:");

            //guardar o input do utilizador nas variáveis a e b, convertendo-as
            //em ints para serem usados para o cálculo
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            //mostrar a soma das variáveis a e b numa string interpolada
            Console.WriteLine($"A soma dos números inseridos é {a + b}");

            Console.ReadKey();
        }
    }
}
