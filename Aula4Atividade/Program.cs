using System;

namespace MyApp
{
    internal class Program
    {
        static double raio = 0;
        static double baseForma = 0;
        static double altura = 0;
        static string nome = "";
        static int opcao = 0;

        /// <summary>
        /// Função que Printa valores na tela
        /// </summary>
        /// <param name="value">Valor a ser printado</param>
        /// return>void</return>

        static void Print(string value)
        {
            Console.WriteLine(value);
        }

        static void Print(double value)
        {
            Console.WriteLine(value);
        }

        static double AreaCirculo(double value)
        {
            double r = 0;
            r = Math.Pow(value, 2) * Math.PI;
            return r;
        }

        static double AreaTriangulo(double b, double a)
        {
            double r = 0;
            r = (b * a) / 2;
            return r;
        }

        static double AreaRetangulo(double b, double a)
        {
            double r = 0;
            r = b * a;
            return r;
        }

        static void Main(string[] args)
        {
            Print("Boas vindas à calculadora de áreas! Como você se chama?");
            nome = Console.ReadLine();
            Print("Escolha qual area quer calcular: 1 - Circulo, 2- Triangulo, 3 - Retangulo");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Print("Insira o Raio do Circulo:");
                raio = double.Parse(Console.ReadLine());
                double resp = AreaCirculo(raio);
                Print(nome + " a Area do circulo " + resp);
            }
            else if (opcao == 2)
            {
                Print("Insira a base do Triangulo:");
                baseForma = double.Parse(Console.ReadLine());
                Print("Insira a altura do Triangulo:");
                altura = double.Parse(Console.ReadLine());
                double resp = AreaTriangulo(baseForma, altura);
                Print(nome + " a Area do Triangulo " + resp);
            }
            else if (opcao == 3)
            {
                Print("Insira a base do Retangulo:");
                baseForma = double.Parse(Console.ReadLine());
                Print("Insira a altura do Retangulo:");
                altura = double.Parse(Console.ReadLine());
                double resp = AreaRetangulo(baseForma, altura);
                Print(nome + " a Area do Retangulo " + resp);
            }
            else
            {
                Print("Opção inválida!");
            }
        }
    }
}

