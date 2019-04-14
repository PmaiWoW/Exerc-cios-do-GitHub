using System;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variáveis
            int a, b, c;
            string resposta;

            //pedir ao utilizador três números inteiros, um por cada variável
            //apresentada no ecrã
            Console.WriteLine("Insere um número inteiro para cada uma das" +
                "seguintes variáveis, para verificar se a soma de quaisquer" +
                "dois deles dá o terceiro:");
            //converter o input do utilizador para cada variável para int
            Console.WriteLine("a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c:");
            c = Convert.ToInt32(Console.ReadLine());

            if (a + b == c || b + c == a || a + c == b)
            {
                resposta = "É possível :)";
            }
            else
            {
                resposta = "Impossível :(";
            }
            Console.WriteLine(resposta);
        }
    }
}
