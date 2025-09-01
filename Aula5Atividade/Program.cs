using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variável para a altura da pirâmide
            int altura = 10;

            // Variável para acompanhar o número da linha atual
            int linhaAtual = 1;

            // Loop while para construir a pirâmide
            while (linhaAtual <= altura)
            {
                // Imprime espaços para centralizar a pirâmide
                int espacos = altura - linhaAtual + 1;
                int contadorEspacos = 0;
                while (contadorEspacos < espacos)
                {
                    Console.Write(" ");
                    contadorEspacos++;
                }

                // Imprime os caracteres (asteriscos) da linha atual
                int contadorAsteriscos = 0;
                while (contadorAsteriscos < linhaAtual)
                {
                    Console.Write(" *");
                    contadorAsteriscos++;
                }

                Console.WriteLine(); // Quebra de linha após cada linha da pirâmide
                linhaAtual++; // Incrementa o número da linha
            }



        }
    }
}