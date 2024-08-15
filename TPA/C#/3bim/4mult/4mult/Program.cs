using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4mult
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cont = 0;

            while(cont < 3)
            {
                cont++;
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());
                num = num * 4;
                Console.Write("Multiplicado: " + num + "\n \n");
                
            }

            Console.WriteLine("Código finalizado");

            Console.ReadKey();
        }
    }
}
