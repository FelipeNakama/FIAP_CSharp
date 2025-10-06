using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Carro : Veiculo
    {
        string modelo;
        public Carro(string placa,string modelo,string cor,string motor) 
        {
            capacidadePessoas = 4;
            this.placa = placa;
            this.modelo = modelo;
            Random random = new Random();
            chassi = random.Next().ToString("0000000000000");
        }



    }
}
