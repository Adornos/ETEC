using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double comprimento, altura, area;

            Console.Write("Digite a medida da base do triãngulo: ");
            comprimento = double.Parse(Console.ReadLine());

            Console.Write("Digite a medida da altura do triãngulo: ");
            altura = double.Parse(Console.ReadLine());

            area = comprimento * altura / 2;

            Console.Write("A area desse triangulo é: " + area);
            Console.ReadKey();
        }
    }
}
