using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Moto : Veiculo
    {
        string modelo;
        public Moto(string placa, string modelo, string cor, string motor)
        {
            capacidadePessoas = 2;
            this.placa = placa;
            this.modelo = modelo;
            Random random = new Random();
            chassi = random.Next().ToString("0000000000000");
        }

        public override string VerificaPessoas()
        {
            return "existem " + this.pessoas + " na " + "Moto" + " contando com o Motociclista";
        }
    }
}
