using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3;
            double val1, val2, val3, total;

            Console.Write("Digite o nome do produto:");
            nome1 = Console.ReadLine();
            Console.Write("Digite o valor do produto: ");
            val1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade vendida: ");
            val1 *= int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do produto:");
            nome2 = Console.ReadLine();
            Console.Write("Digite o valor do produto: ");
            val2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade vendida: ");
            val2 *= int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do produto:");
            nome3 = Console.ReadLine();
            Console.Write("Digite o valor do produto: ");
            val3 = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade vendida: ");
            val3 *= int.Parse(Console.ReadLine());

            total = val1+val2+val3;

            Console.Write("\n  " + nome1 + ": " + val1 + "\n  " + nome2 + ": " + val2 + "\n  " + nome3 + ": " + val3 + "\n\n  O valor total dos produtos é: " + total);
            Console.ReadKey();

        }
    }
}
