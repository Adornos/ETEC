using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If5
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.Write("Digite um número: ");
            numero = double.Parse(Console.ReadLine());

            if (numero < -5)
            {
                Console.WriteLine("O número digitado é menor que -5");
            }

            else if (numero == -5)
            {
                Console.WriteLine("O número digitado é -5");
            }

            else
            {
                Console.WriteLine("O número digitado é maior que -5");
            }

            Console.ReadKey();
        }
    }
}
