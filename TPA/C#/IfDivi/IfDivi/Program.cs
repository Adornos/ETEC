using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfDivi
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, divi;

            Console.Write("Digite um número: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite um número: ");
            numero2 = double.Parse(Console.ReadLine());

            if (numero1 < numero2)
            {
                divi = numero2 / numero1;
                Console.Write(numero2 + " / " + numero1 + " : " + divi);
            }

            else
            {
                divi = numero1 / numero2;
                Console.Write(numero1 + " / " + numero2 + " : " + divi);
            }

            Console.ReadKey();
        }
    }
}
