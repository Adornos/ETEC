using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[6], cargo = new string[6];
            int[] idade = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("\nDigite o nome do funcionário: ");
                nome[i] = Console.ReadLine();
                Console.Write("Digite a idade do funcionário: ");
                idade[i] = int.Parse(Console.ReadLine());
                Console.Write("Digite o cargo do funcionário: ");
                cargo[i] = Console.ReadLine();
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("\nFuncionário: " + nome[i] + " Idade: " + idade[i] + " Cargo: " + cargo[i]);
            }

            Console.ReadLine();
        }
    }
}
