using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizes1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int[] numerosSorted = new int[10];
            int multiplo = 0, aMultiplo = 0;


            for (int i = 0; i < 10; i++)
            {
	            Console.Write("digite um número: ");
	            numeros[i] = int.Parse(Console.ReadLine());
            }

            

            Console.ReadKey();

        }
    }
}
