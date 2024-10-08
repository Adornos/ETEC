using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int i = 0; i < 10; i++)
			{
                Console.Write("Digite um número: ");
                num[i] = int.Parse(Console.ReadLine());
			}

            for (int i = 0; i < 10; i++)
            {
                if (num[i]%2 == 0)
                {
                    Console.WriteLine("Posição " + (i + 1) + ": " + num[i]);
                }

            }
                Console.ReadKey();
        }
    }   
}

