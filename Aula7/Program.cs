using Aula7;
using System;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Veiculo veiculo = new Veiculo(4598324); //
            veiculo.Ligar();
            veiculo.Placa = "asdas"; //
        }
    }
}