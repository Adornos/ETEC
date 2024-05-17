using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double total, somatorio, potencia;

            Console.Write("Informe um número: ");
            somatorio = double.Parse(Console.ReadLine());
            Console.Write("Informe outro número número: ");
            somatorio += double.Parse(Console.ReadLine());
            Console.Write("Informe mais um número: ");
            somatorio += double.Parse(Console.ReadLine());

            potencia = Math.Pow(somatorio, 2);

            Console.WriteLine("O valor da soma dos três números é de: " + somatorio);
            Console.Write("O quadrado do número obtido pela soma dos três números é " + potencia);
            Console.ReadKey();

        }
    }
}
