using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorasTrabalhadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int nAulas, hTrab;
            double inss, salB, salL;

            Console.Write("Digite o valor da hora da aula: ");
            nAulas = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de horas trabalhadas: ");
            hTrab = int.Parse(Console.ReadLine());
            Console.Write("Digite o desconto do INSS: ");
            inss = double.Parse(Console.ReadLine())/100;

            salB = nAulas * hTrab;
            salL = salB - (salB * inss);

            Console.Write("\n  Salário Bruto: " + salB + "\n  Salário Líquido: " + salL);
            
            Console.ReadKey();
        }
    }
}
