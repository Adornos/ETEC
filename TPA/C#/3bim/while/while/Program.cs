using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            int quant, cont = 0;

            Console.Write("Escreva um número para ser contado: ");
            quant = int.Parse(Console.ReadLine());

            while (cont <= quant)
            {
                Console.WriteLine("Numeros: " + cont);
                cont++;
            }
            Console.ReadKey();
        }
    }
}
