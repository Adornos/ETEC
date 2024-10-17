using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[7];

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Digite o nome do time:");
                nome[i] = Console.ReadLine();
            }
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Time " + i + 1 + ": " + nome[i]);
            }
            Console.ReadLine();
        }
    }
}
