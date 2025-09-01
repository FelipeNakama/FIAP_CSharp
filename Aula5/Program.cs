using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicialização  da variável for, condição, incremento
            for (int u = 0; u < 10; u++)
            {
                Console.WriteLine(u);
            }

            int r = 0;
            while (r < 10)
            {
                Console.WriteLine(r);
                r++;
            }

            //Como desenhar um quadrado utilizando laços de repetição
            for (int i = 0; i < 10; i++) //faz a base do quadrado
            {   
                for (int j = 0; j <= 9; j++) //faz a altura do quadrado
                {
                    Console.Write(" *");
                }
                Console.WriteLine(); //Quebra a linha após cada linha de asteriscos
            }

            //Como desenhar um triângulo utilizando laços de repetição, mudando apenas 1 caractere do codigo acima
            for (int i = 0; i < 10; i++) //faz a base do triângulo
            {   
                for (int j = 0; j <= i; j++) //faz a altura do triângulo
                {
                    Console.Write(" *");
                }
                Console.WriteLine(); //Quebra a linha após cada linha de asteriscos
            }

        }
    }
}