using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola Querido!");
            static void Main ()
            {
                Console.Write("Valor em reais ?");
                float reais = float.Parse(Console.ReadLine());

                double usd = reais / 5.22;

                Console.WriteLine("$ = " + usd);

            }

        }
    }
}
