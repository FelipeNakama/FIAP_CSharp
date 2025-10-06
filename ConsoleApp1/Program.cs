using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculos = new Veiculo[4];

            veiculos[0] = new Carro("hjk2324", "santana", "vinho", "AP2.0");
            veiculos[1] = new Moto("hgj5476", "cb500", "preta", "500cc");
            veiculos[2] = new Moto("sgf5678", "Hayabusa", "azul", "1200cc");
            veiculos[3] = new Pickup("fgh4567", "saveiro", "branca", "AP1.8", 700);
 
            for (int i = 0; i < veiculos.Length; i++) 
            { 
                veiculos[i].LigarMotor();
                veiculos[i].AdicionaPessoas(2);
                Console.WriteLine(veiculos[i].VerificaPessoas());
            }

        }
    }
}