using System;

namespace MyApp
{
    internal class Program
    {
        static double raio = 0;

        static void Print(string value)
        {
            Console.WriteLine(value);
        }

        static void Print(double value) //sobrecarga
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Função que calcula a area do circulo
        /// </summary>
        /// <param name="value">Raio do circulo</param>
        /// return>Area do circulo</return>


        static double AreaOfCircle(double value)
        {
            double r = 0;
            r = Math.Pow(value, 2) * Math.PI;
            return r;
        }


        static void Main(string[] args)
        {
            Print("Insira o Raio do Circulo:");
            raio = double.Parse(Console.ReadLine());
            double resp = AreaOfCircle(raio);
            Print("Area do circulo " + resp);
        }
    }
}

