using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, soma;

            Console.Write("Escreva um número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Escreva um número: ");
            num2 = double.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine(num1 + " + " + num2 + " = " + soma);
            Console.ReadKey();
        }
    }
}
