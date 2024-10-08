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
            string[] cores = new string[15];

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Digite o nome da " + (i + 1) + "ª Cor: ");
                cores[i] = Console.ReadLine().Trim();
            }

            Console.ReadKey();

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Cor " + (i + 1) + " : " + cores[i]);
            }

            Console.ReadKey();
        }
    }   
}
