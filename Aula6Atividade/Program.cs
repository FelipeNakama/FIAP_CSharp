using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nesse jeito, vc digita os 4 numeros de uma vez só, ao inves de um por vez como no exemplo acima
            int[] listaNumeros = { 5, 6, 4, 9 };

            Console.WriteLine("Digite 4 numeros separados por espaço:");
            string[] entrada = Console.ReadLine().Split(' '); // Lê a entrada do usuário e divide em partes usando espaço como separador

            if (entrada.Length != listaNumeros.Length)
            {
                Console.WriteLine("Por favor, digite exatamente 4 números.");
                return; // Sai do programa se o número de entradas for diferente de 4
            }

            for(int i = 0; i < entrada.Length; i++)
            {
                if (int.Parse(entrada[i]) == listaNumeros[i])
                {
                    Console.WriteLine("Senha correta! Acesso concedido.");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha incorreta, tente novamente.");
                    return;
                }
            }
        }
    }
}