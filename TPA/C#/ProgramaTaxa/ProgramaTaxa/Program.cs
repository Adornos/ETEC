using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTaxa
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, parcelas, taxa, total;

            Console.Write("Digite o valor de cada prestação: ");
            valor = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de parcelas: ");
            parcelas = double.Parse(Console.ReadLine());
            Console.Write("informe a taxa de juros: ");
            taxa = double.Parse(Console.ReadLine());
            
            total = valor + (valor*taxa/100)*parcelas);
            Console.Write("O valor total do móvel será " + total);
            Console.ReadKey();
        }
    }
}
