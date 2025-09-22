using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    internal class Veiculo
    {
        private string placa;

        private int codigoFabrica;

        // botao direito no codigoFabrica -> Quick Actions and Refactorings... generate constructor 'Veiculo'
        // Construtor: metodo especial que tem o mesmo nome da classe e nao tem retorno
        // essa classe exige que o codigoFabrica seja informado na criacao do objeto carro
        public Veiculo(int codigoFabrica)
        {
            this.codigoFabrica = codigoFabrica;
        }

        // Botao direito no placa -> Quick Actions and Refactorings... -> Encapsulate field and use properties...
        // Criou o getter e o setter da placa. O getter retorna o valor da placa e o setter atribui um valor a placa.
        public string Placa { get => placa; set => placa = value; } 

        public void Ligar() 
        { 
            Console.WriteLine("O veículo está ligado.");

        }
    }
}
