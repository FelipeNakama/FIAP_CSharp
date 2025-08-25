using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa com dois valores que cheque se a soma deles é maior ou menor que zero.

            int n1, n2;
            int r;

            Console.WriteLine("Digite o primeiro valor:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            n2 = int.Parse(Console.ReadLine());

            r = n1 + n2;

            if (r == 0)
            {
                Console.WriteLine("O valor é Zero");

            }
            if (r > 0)
            {
                Console.WriteLine("O valor é maior que Zero");

            }
            if (r < 0)
            {
                Console.WriteLine("O valor é menor que Zero");
            }

        }
    }
}

