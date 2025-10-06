using System;

namespace Checkpoint2_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> frota = new List<Veiculo>
            {
                new Carro(),
                new Caminhao(),
                new Moto()
            };

            for (int i = 0; i < frota.Count; i++)
            {
                frota[i].Acelerar();
                Console.WriteLine();
            }
        }
    }
}