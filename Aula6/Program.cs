using System;

namespace MyApp
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            int[] listaNumeros = { 5, 6, 4, 9 }; // "[]" determina um array de numeros inteiros, inicialização direta

            int[] numero = {0, 0, 0, 0 }; // Array para armazenar os números inputados pelo usuário

            while (true)
            {
                Console.WriteLine("Descubra a senha **** ");

                for (int i = 0; i < listaNumeros.Length; i++) // Varre a lista de numeros usando o Length para determinar o tamanho do array
                {
                    Console.WriteLine("Dígito " + (i + 1)); // Mostra o dígito atual (i + 1 para começar do 1 ao invés de 0)
                    listaNumeros[i] = int.Parse(Console.ReadLine()); // Lê o número inputado pelo usuário e armazena na posição i do array

                }

                for (int i = 0; i < listaNumeros.Length; i++) 
                {
                    if (listaNumeros[i] != listaNumeros[i])
                    {
                        Console.WriteLine("Senha incorreta, tente novamente.");
                        break; // Sai do loop se um dígito estiver incorreto
                    }
                    if (i == listaNumeros.Length - 1)
                    {
                        Console.WriteLine("Senha correta! Acesso concedido.");
                        return; // Sai do programa se todos os dígitos estiverem corretos
                    }
                }

            }
            
        }
    } */

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

        }
    }
}