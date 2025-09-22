using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7Atividade
{
    internal class Carro
    {
        private string chassis;
        private string licensePlate;
        private string cor;
        private string motor;

        public Carro(string chassis, string licensePlate, string cor, string motor)
        {
            this.Chassis = chassis;
            this.LicensePlate = licensePlate;
            this.Cor = cor;
            this.Motor = motor;
        }

        public string Chassis { get => Chassis; set => Chassis = value; }
        public string LicensePlate { get => LicensePlate; set => LicensePlate = value; }
        public string Cor { get => Cor; set => Cor = value; }
        public string Motor { get => Motor; set => Motor = value; }

    }
}
