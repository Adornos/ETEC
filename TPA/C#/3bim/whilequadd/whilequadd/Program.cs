using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whilequadd
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, quant, square;

            Console.Write("Digite um número: ");
            quant = int.Parse(Console.ReadLine());

            while(cont <= quant)
            {
                square = cont*cont;
                cont++;
                Console.WriteLine("Contador: " + cont + " | Quadrado: " + square);
            }

            Console.ReadKey();
        }
    }
}
