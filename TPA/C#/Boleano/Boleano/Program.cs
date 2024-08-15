using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleano
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            //Comparação da variável "numero"
            if (numero > 100)
            {
                Console.WriteLine("O número digitado é maior que 100");
            }
            else if(numero == 100)
            {
                Console.WriteLine("O número é igual a 100");
            }
            else
            {
                Console.WriteLine("O número digitado é menor que 100");
            }         

            Console.ReadKey();
        }
    }
}
