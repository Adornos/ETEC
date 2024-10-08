using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20andcont
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Digite um número: ");
                int n = int.Parse(Console.ReadLine());

                if (n%2==0)
                {
                    par++;
                }
            }
            Console.WriteLine(par + " núemros pares digitados");
            Console.ReadKey();
        }
    }
}
