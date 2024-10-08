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
            string[] players = new string[11];

            for (int i = 0; i < 11; i++)
            {
                Console.Write("Digite o nome do " + (i + 1) + "º jogador: ");
                players[i] = Console.ReadLine().Trim();
            }

            Console.ReadKey();

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Jogador " + i + 1 + " : " + players[i]);
            }

            Console.ReadKey();
        }
    }   
}
