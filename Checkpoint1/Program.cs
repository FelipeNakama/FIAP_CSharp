// Projeto de Avaliação (Revisado) - Variante 2: Verificação de número primo
// O código a seguir deve ler um número inteiro do usuário e informar se ele é primo.
// Para aumentar a dificuldade, a implementação possui erros de tipo, lógica e fluxo.

using System;

class Program
{   // Declarei a variavel numero para poder aplicar o int.Parse no input
    static int numero = 0;

   //Faltou String[] args
    static void Main(String[] args) 
    {
        Console.Write("Informe um número natural: ");

        // C# nao tem conversão automática de variável. Então temos que transformar a string do input em int
        numero = int.Parse(Console.ReadLine()); 
        bool ePrimo;

        ePrimo = VerificarPrimo(numero);

        if (ePrimo == true) // A lógica ePrimo == false estava invertida, apontando primos como não primos e vice-versa 
            Console.WriteLine("O número " + numero + " é primo");
        else
            Console.WriteLine("O número " + numero + " não é primo"); // Pequeno ajuste no print para mostrar o numero inserido
    }


    static bool VerificarPrimo(int n)
    {
        bool primo = true;

        // Essa função nao checa se o número inserido é menor que 2, já que 1 e 2 não são primos
        if (n < 2)  return false; 
        
        // O intuito é testar todos os divisores possíveis a partir de 2, então o correto é divisor++ para incrementar o divisor e nao diminuir
        for (int divisor = 2; divisor <= n / divisor; divisor++) 
        {
            if (n % divisor == 0)
            {
                primo = false;
                break;
            }
        }
        // O return = true sempre será executado por ultimo, entao a função sempre retornará true independentemente do valor de primo
        return primo;
        // Como primo é boolean, basta retornar ele diretamente, após sua verificação
    }
}