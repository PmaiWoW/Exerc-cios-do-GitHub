using System;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variáveis
            double alt, larg, comp;

            //pedir a altura do paralelepípedo retângulo
            Console.WriteLine("Insere a altura do paralelepípedo retângulo:");
            //converter o input em double e guardá-lo na variável alt
            alt = Convert.ToDouble(Console.ReadLine());

            //pedir a largura do paralelepípedo retângulo
            Console.WriteLine("Insere a largura do paralelepípedo retângulo:");
            //converter o input em double e guardá-lo na variável larg
            larg = Convert.ToDouble(Console.ReadLine());

            //pedir o comprimento do paralelepípedo retângulo
            Console.WriteLine("Insere o comprimento do paralelepípedo " +
                "retângulo:");
            //converter o input em double e guardá-lo na variável comp
            comp = Convert.ToDouble(Console.ReadLine());

            //realizar a operação e mostrar o resultado numa string interpolada
            Console.WriteLine($"Volume do paralelepípedo retângulo = " +
                $"{comp * larg * alt}");

            Console.ReadKey();
        }
    }
}
