using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, soma;

            Console.Write("Digite um número: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            numero2 = double.Parse(Console.ReadLine());

            soma = numero1 + numero2;

            if (soma > 30)
            {

                Console.Write("O número é maior que 30.");
            }

            else if(soma == 30)
            {
                Console.Write("O número é igual 30.");
            }

            else
            {

                Console.Write("O número é menor que 30.");
            }

            Console.ReadKey();
        }
    }
}
