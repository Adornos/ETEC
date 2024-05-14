using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_do_cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado, area, volume;

            Console.Write("Digite a medida do lado do cubo: ");
            lado = double.Parse(Console.ReadLine());

            area = Math.Pow(lado, 2);
            volume = Math.Pow(lado, 3);

            Console.WriteLine("A area da base desse cubo é: " + area + "\nO volume desse cubo é: " + volume);
            

            Console.Write("\nA area da base desse cubo é: " + Math.Pow(lado, 2) + "\nO volume desse cubo é: " + Math.Pow(lado, 3));
            Console.ReadKey();

        }
    }
}
