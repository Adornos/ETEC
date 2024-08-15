using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace div3
{
    class Program
    {
        static void Main(string[] args)
        {
            double final, calculo, contagem = 10;

            Console.Write("Digite a quantidade maior que 10: ");
            final = int.Parse(Console.ReadLine());

            while (contagem <= final)
            {
                calculo = contagem / 3;
                Console.WriteLine(calculo);
                contagem++;
            }

            Console.ReadKey();
        }
    }
}
