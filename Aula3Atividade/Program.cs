using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2;

            Console.WriteLine("Digite a Idade do Primeiro Estudante:");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Idade do Segundo Estudante:");
            idade2 = int.Parse(Console.ReadLine());

            if (idade1 > idade2)
            {
                Console.WriteLine("O Primeiro Estudante é mais velho que o Segundo Estudante.");
            }
            if (idade1 < idade2)
            {
                Console.WriteLine("O Segundo Estudante é mais velho que o Primeiro Estudante.");
            }
            if (idade1 == idade2)
            {
                Console.WriteLine("Os dois estudantes têm a mesma idade.");

            }
        }
    }
}