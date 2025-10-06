using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Veiculo
    {
        protected string placa;
        protected string chassi;
        protected string cor;
        protected string motor;

        bool motorLigado;
        protected int capacidadePessoas;
        protected int pessoas;
        protected float estadoDoTanque;

        public void LigarMotor()
        {
            motorLigado = true;
        }

        public void DesligarMotor()
        { 
            motorLigado = false; 
        }
        public int EstadoTanque()
        { 
            //retorno em %
            return  (int)(estadoDoTanque * 100);
        }
        public void AdicionaPessoas(int pessoas)
        {
            if (pessoas > capacidadePessoas)
            {
                Console.WriteLine("Lotado");
            }
            this.pessoas += pessoas;
        }
        public virtual string VerificaPessoas()
        {
            return "existem " + this.pessoas + " no " + this.GetType().Name + " contando com o Motorista";
        }


    }
}
