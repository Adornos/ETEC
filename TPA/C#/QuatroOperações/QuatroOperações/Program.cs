using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuatroOperações
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, soma, subt, mult, divi;

            Console.Write("Digite um número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            num2 = double.Parse(Console.ReadLine());

            soma = num1+num2;
            subt = num1-num2;
            mult = num1*num2;
            divi = num1/num2;

            Console.WriteLine(" Soma = " + soma);
            Console.WriteLine(" Subtração = " + subt);
            Console.WriteLine(" Multiplicação = " + mult);
            Console.WriteLine(" Divisão = " + divi);
            Console.ReadKey();
          

        }
    }
}
