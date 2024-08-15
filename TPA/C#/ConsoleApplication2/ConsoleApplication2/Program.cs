using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numP;

            Console.WriteLine("Digite o número de pessoas: ");
            numP = int.Parse(Console.ReadLine());

            if (numP < 1001)
            {
                Console.WriteLine("Publico Baixo");
            }
            else if (numP > 10000)
            {
                Console.WriteLine("Publico Alto");
            }
            else
            {
                Console.WriteLine("Publico médio");
            }
            Console.ReadLine();
        }
    }
}
