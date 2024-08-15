using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfPosiQuad
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, compara;

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                compara = numero/2;
                Console.WriteLine("O número é positivo. E sua metade é: " + compara);
            }

            else
            {
                compara = Math.Pow(numero, 2);
                Console.WriteLine("O número é negativo. E seu quadrado é: " + compara);
            }

            Console.ReadLine();
        }
    }
}
