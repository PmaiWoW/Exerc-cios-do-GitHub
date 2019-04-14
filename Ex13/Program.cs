using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variáveis
            double d, e;

            //pede o valor real para usar como base para a potenciação
            Console.WriteLine("Insere um nº real de base para a potenciacão:");
            //converte o valor real dado para double, para ser usada em calcs
            d = Convert.ToDouble(Console.ReadLine());
            //pede o valor real para usar como expoente para a potenciação
            Console.WriteLine("Insere um nº real de expoente para a " +
                "potenciacão:");
            //converte o valor real dado para double, para ser usada em calcs
            e = Convert.ToDouble(Console.ReadLine());

            //realizar a operação e mostrar o resultado numa string interpolada
            Console.WriteLine($"Potenciação(base:{d}, expoente:{e}) = " +
                $"{Math.Pow(d, e)}");

            Console.ReadKey();
        }
    }
}
